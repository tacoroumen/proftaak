#ifndef NETWORK_H
#define NETWORK_H
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