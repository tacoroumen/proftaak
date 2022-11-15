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
const char* ssid = "NETLAB-OIL010";
const char* password = "DesignChallenge";

// Add your MQTT Broker IP address, example:
//const char* mqtt_server = "192.168.1.144";
const char* mqtt_server = "192.168.160.210"; 
WiFiClient espClient;
PubSubClient client(espClient);
long lastMsg = 0;
char msg[50];
const int ledPin = 2;

//scale variables
float price = 0;
float weight = 0;
float total_weight = 0;
float total_price = 0;

//string for serial monitor
String value;