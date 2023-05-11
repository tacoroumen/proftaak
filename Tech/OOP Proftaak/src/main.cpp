#include <Arduino.h>
#include <Wire.h>
#include "Scale.h"
#include "MQTT.h"
#include "Network.h"
#include "Servo_prof.h"
const int _clockpin = 4;
const int _datapin = 5;
const char *ssid = "NETLAB-OIL010";
const char *password = "DesignChallenge";
const char *mqtt_server = "145.220.75.105";
float weight_kg  = 0;
Servo_prof(5);

void setup() {
  // put your setup code here, to run once:
  Servo_prof::init();
  Scale(_clockpin, _datapin);
  MQTT_prof("192.168.160.210", 1883);
  Network::wifi_setup();
  Network(*ssid, *password);

}

void loop() {
  weight_kg = Scale::measure();
  MQTT_prof::upload(weight_kg);
  MQTT_prof::callbackback();
  // put your main code here, to run repeatedly:
}