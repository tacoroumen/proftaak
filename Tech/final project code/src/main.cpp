#include <Arduino.h>
#include <SPI.h>
#include <WiFi.h>
#include <PubSubClient.h>
#include <Servo.h>
#include <HX711.h>
#include <HX711_ADC.h>
#include <MFRC522.h>

// global variables
bool Weigh_again = true;

// initialize scale
HX711 scale;
const int CLOCKPIN = 14;
const int DATAPIN = 12;
HX711_ADC LoadCell(DATAPIN, CLOCKPIN);

// Replace the next variables with your SSID/Password combination
const char *ssid = "NETLAB-OIL010";
const char *password = "DesignChallenge";

// Add your MQTT Broker IP address, example:
const char *mqtt_server = "145.220.75.105";
int port = 1883;
WiFiClient espClient;
PubSubClient client(espClient);
long lastMsg = 0;
char msg[50];
String UID;

// scale variables
float weight = 0;
float total_weight = 0;


// string for serial monitor
String message;

// Servo
Servo servo;
int Servo_pin = 32;


//MFRC522
//Constants
#define SS_PIN 5
#define RST_PIN 0
//Variables
byte nuidPICC[4] = {0, 0, 0, 0};
MFRC522::MIFARE_Key key;
MFRC522 rfid = MFRC522(SS_PIN, RST_PIN);

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

void mqtt_update() {
  char currentstring[11];
  float weight_kg = weight / 1000;
  dtostrf(weight_kg, 1, 2, currentstring);
  Serial.print("Weight in kg: ");
  Serial.println(currentstring);
  client.publish("fontys/weight", currentstring);
}

void mqtt_update_uid() {
  Serial.println(UID);
  char uid[11];
  UID.toCharArray(uid,11);
  Serial.print("UID: ");
  Serial.println(uid);
  client.publish("fontys/user", uid);
}

void calibrate()
{
  LoadCell.tare();
  Serial.println("Calibration start");
  LoadCell.refreshDataSet(); // refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue);
  Serial.println("Calibration done");
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
  mqtt_update();
  Weigh_again = false;
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

  if (String(topic) == "fontys/status")
  {
    Serial.print("Changing status to ");
    if (messageTemp == "Done")
    {
      Serial.println("Done");
      scale.tare();
      mqtt_update_uid();
      servo.write(90);
      Weigh_again = true;
    }
    else if (messageTemp == "Busy")
    {
      Serial.println("Busy");
      Weigh_again = true;
    }
    else if (messageTemp == "Denied")
    {
      Serial.println("Denied");
      Serial.println("Card was declined");
    }
  }
  if (String(topic) == "fontys/material")
  {
    Serial.print("Changing material to ");
    if (messageTemp == "General Waste")
    {
      Serial.println("General Waste");
      servo.write(90);
    }
    else if (messageTemp == "Plastic")
    {
      Serial.println("Plastic");
      servo.write(45);
    }
    else if (messageTemp == "Paper")
    {
      Serial.println("Paper");
      servo.write(135);
    }
  }
}
void MQTT_reconnect()
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
      client.subscribe("fontys/status");
      client.subscribe("fontys/material");
      mqtt_update();
      mqtt_update_uid();
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

void printHex(byte *buffer, byte bufferSize) {
 	for (byte i = 0; i < bufferSize; i++) {
 			Serial.print(buffer[i] < 0x10 ? ":0" : ":");
 			Serial.print(buffer[i], HEX);
      UID = UID + (buffer[i]);
 	}
  mqtt_update_uid();
  UID = "";

}

void readRFID(void ) { /* function readRFID */
 	////Read RFID card
 	for (byte i = 0; i < 6; i++) {
 			key.keyByte[i] = 0xFF;
 	}
 	// Look for new 1 cards
 	if ( ! rfid.PICC_IsNewCardPresent())
 			return;
  
 	// Verify if the NUID has been read
 	if ( 	!rfid.PICC_ReadCardSerial())
 			return;
 	// Store NUID into nuidPICC array
 	for (byte i = 0; i < 4; i++) {
 			nuidPICC[i] = rfid.uid.uidByte[i];
 	}
 	Serial.print(F("UID In hex: "));
 	printHex(rfid.uid.uidByte, rfid.uid.size);
 	Serial.println();
 	// Halt PICC
 	rfid.PICC_HaltA();
 	// Stop encryption on PCD
 	rfid.PCD_StopCrypto1();
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
 	Serial.println(F("Initialize System"));
 	//init rfid D8,D5,D6,D7
 	SPI.begin();
 	rfid.PCD_Init();
 	Serial.print(F("Reader :"));
 	rfid.PCD_DumpVersionToSerial();
  servo.attach(Servo_pin);
  scale.begin(DATAPIN, CLOCKPIN);
  scale.tare();
  LoadCell.begin();
  setup_wifi();
  calibrate();
  client.setServer(mqtt_server, port); // set mqtt server
  client.setCallback(callback);
}
 
void loop() {
  // put your main code here, to run repeatedly:
  if (!client.connected()){
    MQTT_reconnect();
  }
  client.loop();
  readRFID();
  weight = scale.get_units(10);
  if (weight > 1 && Weigh_again == true)
  {
    measurements(); // Function to measure weight once.
  }
}