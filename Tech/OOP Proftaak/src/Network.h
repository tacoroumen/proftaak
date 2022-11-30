#ifndef MQTT_H
#define MQTT_H
#include <Arduino.h>
#include <WiFi.h>

class Network {
  
  private:
    byte pin;
    
  public:
    Network(byte pin);
    void init();
    void on();
    void off();
};
#endif