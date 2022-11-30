#ifndef SCALE_H
#define SCALE_H
#include <Arduino.h>
#include <HX711.h>
#include <HX711_ADC.h>

class Scale {
  
  private:
    byte pin;
    
  public:
    Scale(byte pin);
    void init();
    void on();
    void off();
};
#endif