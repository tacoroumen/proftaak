#ifndef MQTT_H
#define MQTT_H
#include <Arduino.h>
#include <PubSubClient.h>

class MQTT {
  
  private:
    byte pin;
    
  public:
    MQTT(byte pin);
    void init();
    void on();
    void off();
};
#endif