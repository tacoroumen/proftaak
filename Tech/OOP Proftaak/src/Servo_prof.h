#ifndef SERVO_H
#define SERVO_H
#include <Arduino.h>
#include <servo.h>
Servo servo;

class Servo_prof {
  
  private:
    int _pin;
    
  public:
    Servo_prof(int _pin);
    void init();
    void paper();
    void general_waste();
    void plastic();
};
#endif