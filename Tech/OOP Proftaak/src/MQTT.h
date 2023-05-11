#ifndef MQTT_H
#define MQTT_H
#include <Arduino.h>
#include <WiFi.h>
#include <PubSubClient.h>
WiFiClient espClient;
PubSubClient client(espClient);

class MQTT_prof {
  private:
    int _state;
    float _weight_kg;
    const char *_mqtt_server;
    int _port;
    long _lastMsg = 0;
    char _msg[50];
    const int _ledPin = 2;
    
  public:
    MQTT_prof(const char *_mqtt_server, int _port);
    void upload(float _weight_kg);
    void callbackback(char *topic, byte *message, unsigned int length);
};
#endif