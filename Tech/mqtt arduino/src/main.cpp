#include "include.cpp"
#include "functions.cpp"

void setup() {
  Serial.begin(115200);
  scale.begin(DATAPIN, CLOCKPIN);
  scale.tare();
  LoadCell.begin();
  Serial.println("Please remove all mass from the scale, when all mass is removed press enter."); 
  char received = Serial.read();
  while (received != '\n'){
    char received = Serial.read();
  }
  calibrate(); //start calibration
  setup_wifi(); 
  client.setServer(mqtt_server, 1883); //set mqtt server
  client.setCallback(callback);
}


void loop() {
  if (!client.connected()) {
    reconnect();
  }
  client.loop();

  long now = millis();
  weight = scale.get_units(10);      
  if (weight > 1){
    measurements(); //Function to measure weight once.
  }
  if (now - lastMsg > 5000) {
    lastMsg = now;
    // Convert the value to a char array
    mqqt_update();
  }
}