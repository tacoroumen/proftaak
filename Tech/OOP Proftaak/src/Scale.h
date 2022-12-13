#ifndef SCALE_H
#define SCALE_H
#include <Arduino.h>
#include <HX711.h>
#include <HX711_ADC.h>
HX711 scale;
const int _clockpin = 4;
const int _datapin = 5;
HX711_ADC LoadCell(_datapin, _clockpin);

class Scale {
  
  private:
    float _weight;
    float _weight_kg;
    int _clockpin;
    int _datapin;
    
  public:
    Scale(int _clockpin, int _datapin);
    void init();
    void calibrate();
    float measure();
    
};
#endif