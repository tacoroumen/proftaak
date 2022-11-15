#include "include.cpp"

void calibrate() {
  Serial.println("Calibration start");
  LoadCell.refreshDataSet(); //refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue); 
  delay(500);
  Serial.println("Calibration finished");
  delay(1000);
  Serial.print('\n');
  Serial.println("Please put the object you want to measure on the scale");
}

void priceofplastic(){
  price = weight / 1000 * 0.75;
  Serial.print('\n');
  Serial.print("price: ");
  Serial.print(price);
  Serial.print(" euro");
  Serial.print('\n');
  
  total_price = total_price + price;     
  Serial.print("Total price: ");
  Serial.print(total_price);
  Serial.print(" euro");
  Serial.println('\n');
}


void measurements(){
  weight = scale.get_units(10);
  total_weight = total_weight + weight;  
  Serial.print('\n');
  Serial.print("Weight: ");   
  Serial.print(weight); 
  Serial.print(" grams");
  Serial.print('\n'); 

  Serial.print("Total weight: ");
  Serial.print(total_weight);
  Serial.print(" grams");

  priceofplastic(); //measure and print the price of the measured object

  delay(1500);
  Serial.println("Please remove said object from the scale");
  delay(3000);
  Serial.print('\n');

  serialread();
}
void serialread(){
  Serial.println("Do you wish to continue measuring?");
  Serial.println("Send 'yes' if you wish to continue and 'no' if you wish to stop");

  if (Serial.available() > 0){
    char received = Serial.read();
    if (received == '\n'){
      if (value == "yes"){
        Serial.println("yes");
        value = "";
      }
      if (value == "no"){
        Serial.println("no");
        value = "";
      }
    }else {
      value += received; 
    }
  } 
}
void setup_wifi() {
  delay(10);
  // We start by connecting to a WiFi network
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);

  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

void callback(char* topic, byte* message, unsigned int length) {
  Serial.print("Message arrived on topic: ");
  Serial.print(topic);
  Serial.print(". Message: ");
  String messageTemp;
  
  for (int i = 0; i < length; i++) {
    Serial.print((char)message[i]);
    messageTemp += (char)message[i];
  }
  Serial.println();

  // Feel free to add more if statements to control more GPIOs with MQTT

  // If a message is received on the topic esp32/output, you check if the message is either "on" or "off". 
  // Changes the output state according to the message
  if (String(topic) == "proftaak/fontys/led") {
    Serial.print("Changing output to ");
    if(messageTemp == "on"){
      Serial.println("on");
      digitalWrite(ledPin, HIGH);
    }
    else if(messageTemp == "off"){
      Serial.println("off");
      digitalWrite(ledPin, LOW);
    }
  }
}

void reconnect() {
  // Loop until we're reconnected
  while (!client.connected()) {
    Serial.print("Attempting MQTT connection...");
    // Attempt to connect
    if (client.connect("ESP8266Client", "proftaak", "04juLi2003!")) {
      Serial.println("connected");
      // Subscribe
      client.subscribe("proftaak/fontys/led");
    } else {
      Serial.print("failed, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 5 seconds");
      // Wait 5 seconds before retrying
      delay(5000);
    }
  }
}

void mqqt_update() {
    char currentstring[8];
    float weight_kg = weight/1000;
    dtostrf(weight_kg, 1, 2, currentstring);
    Serial.print("Weight in kg: ");
    Serial.println(currentstring);
    client.publish("proftaak/fontys/weight", currentstring);

    char currentstring[8];
    float total_weight_kg = total_weight/1000;
    dtostrf(total_weight_kg, 1, 2, currentstring);
    Serial.print("Total weight in kg: ");
    Serial.println(currentstring);
    client.publish("proftaak/fontys/total_weight", currentstring);

    char currentstring[8];
    dtostrf(price, 1, 2, currentstring);
    Serial.print("price in euro: ");
    Serial.println(currentstring);
    client.publish("proftaak/fontys/price", currentstring);

    char currentstring[8];
    dtostrf(total_price, 1, 2, currentstring);
    Serial.print("Total price in euro: ");
    Serial.println(currentstring);
    client.publish("proftaak/fontys/total_price", currentstring);
}