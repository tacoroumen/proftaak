#ifndef NETWORK_H
#define NETWORK_H
#include <Arduino.h>
#include <WiFi.h>

class Network {
  
  private:
    char *ssid;
    char *password;
    
  public:
    Network(char *ssid, char *password);
    void setup();
    void wifi_setup();
};
#endif