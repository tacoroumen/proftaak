#include <Arduino.h>
#include <Wire.h>
#include "Scale.h"
#include "MQTT.h"
#include "Network.h"
const int _clockpin = 4;
const int _datapin = 5;
const char *ssid = "NETLAB-OIL010";
const char *password = "DesignChallenge";
const char *mqtt_server = "145.220.75.105";
float weight = 0;

void setup() {
  // put your setup code here, to run once:
  Scale(_clockpin, _datapin);
}

void loop() {
  // put your main code here, to run repeatedly:
}