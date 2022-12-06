#include <Arduino.h>
#include <WiFi.h>
#include <HX711.h>
#include <HX711_ADC.h>
#include <PubSubClient.h>
#include <Wire.h>

// initialize scale
HX711 scale;
const int CLOCKPIN = 4;
const int DATAPIN = 5;
HX711_ADC LoadCell(DATAPIN, CLOCKPIN);

// Replace the next variables with your SSID/Password combination
const char *ssid = "NETLAB-OIL010";
const char *password = "DesignChallenge";

// Add your MQTT Broker IP address, example:
// const char* mqtt_server = "192.168.1.144";
const char *mqtt_server = "192.168.160.210";
WiFiClient espClient;
PubSubClient client(espClient);
long lastMsg = 0;
char msg[50];
const int ledPin = 2;

// scale variables
float price = 0;
float weight = 0;
float total_weight = 0;
float total_price = 0;

// string for serial monitor
String message;

void mqtt_update()
{
  char currentstring[8];
  float weight_kg = weight / 1000;
  dtostrf(weight_kg, 1, 2, currentstring);
  Serial.print("Weight in kg: ");
  Serial.println(currentstring);
  client.publish("proftaak/fontys/weight", currentstring);

  currentstring[8];
  float total_weight_kg = total_weight / 1000;
  dtostrf(total_weight_kg, 1, 2, currentstring);
  Serial.print("Total weight in kg: ");
  Serial.println(currentstring);
  client.publish("proftaak/fontys/total_weight", currentstring);

  dtostrf(price, 1, 2, currentstring);
  Serial.print("price in euro: ");
  Serial.println(currentstring);
  client.publish("proftaak/fontys/price", currentstring);

  dtostrf(total_price, 1, 2, currentstring);
  Serial.print("Total price in euro: ");
  Serial.println(currentstring);
  client.publish("proftaak/fontys/total_price", currentstring);
}

void calibrate()
{
  LoadCell.tare();
  Serial.println("Calibration start");
  LoadCell.refreshDataSet(); // refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue);
  delay(500);
  Serial.println("Calibration finished");
  delay(1000);
  Serial.println("Please put the object you want to measure on the scale");
}

void priceofplastic()
{
  price = weight / 1000 * 0.75;
  Serial.print("price: ");
  Serial.print(price);
  Serial.println(" euro");

  total_price = total_price + price;
  Serial.print("Total price: ");
  Serial.print(total_price);
  Serial.println(" euro");
}

void serialread()
{
  if (Serial.available() > 0) {
    char received = Serial.read();
    
    if (received == '\n') {
      if (message == "yes"){
        Serial.println("Please put the object you want to measure on the scale");
      }
      else if (message == "no") {
        mqtt_update();
        Serial.println("Thank you for using our project!");
        Serial.print("Your total money back is: ");
        Serial.print(total_price);
        Serial.println(" euro");
        Serial.print("The total weight of the measured objects is: ");
        Serial.print(total_weight / 1000);
        Serial.println(" kilograms");
        total_price = 0;
        total_weight = 0;
        //print receipt for customer
      }
      message = ""; 
    }else {
      message += received;
    }
  }
}

void measurements()
{
  weight = scale.get_units(10);
  total_weight = total_weight + weight;
  Serial.print("Weight: ");
  Serial.print(weight);
  Serial.println(" grams");

  Serial.print("Total weight: ");
  Serial.print(total_weight);
  Serial.println(" grams");

  priceofplastic(); // measure and print the price of the measured object

  delay(500);
  Serial.println("Please remove said object from the scale");
  delay(500);

  Serial.println("Do you wish to continue measuring?");
  Serial.println("Send 'yes' if you wish to continue and 'no' if you wish to stop");
}

void setup_wifi()
{
  delay(10);
  // We start by connecting to a WiFi network
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);

  WiFi.begin(ssid, password); 

  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

void callback(char *topic, byte *message, unsigned int length)
{
  Serial.print("Message arrived on topic: ");
  Serial.print(topic);
  Serial.print(". Message: ");
  String messageTemp;

  for (int i = 0; i < length; i++)
  {
    Serial.print((char)message[i]);
    messageTemp += (char)message[i];
  }
  Serial.println();

  // Feel free to add more if statements to control more GPIOs with MQTT

  // If a message is received on the topic esp32/output, you check if the message is either "on" or "off".
  // Changes the output state according to the message
  if (String(topic) == "proftaak/fontys/led")
  {
    Serial.print("Changing output to ");
    if (messageTemp == "on")
    {
      Serial.println("on");
      digitalWrite(ledPin, HIGH);
    }
    else if (messageTemp == "off")
    {
      Serial.println("off");
      digitalWrite(ledPin, LOW);
    }
  }
}

void reconnect()
{
  // Loop until we're reconnected
  while (!client.connected())
  {
    Serial.print("Attempting MQTT connection...");
    // Attempt to connect
    if (client.connect("ESP32Client", "proftaak", "04juLi2003!"))
    {
      Serial.println("connected");
      // Subscribe
      client.subscribe("proftaak/fontys/led");
      mqtt_update();
    }
    else
    {
      Serial.print("failed, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 5 seconds");
      // Wait 5 seconds before retrying
      delay(5000);
    }
  }
}

void setup()
{
  Serial.begin(9600);
  scale.begin(DATAPIN, CLOCKPIN);
  scale.tare();
  LoadCell.begin();
  setup_wifi();
  calibrate();                         // start calibration
  client.setServer(mqtt_server, 1883); // set mqtt server
  client.setCallback(callback);
}

void loop()
{
  if (!client.connected())
  {
    reconnect();
  }
  client.loop();

  long now = millis();
  weight = scale.get_units(10);
  if (weight > 1)
  {
    measurements(); // Function to measure weight once.
  }
  serialread();
}