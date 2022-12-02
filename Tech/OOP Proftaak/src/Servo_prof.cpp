#include "Servo_prof.h"
Servo_prof.Servo_prof(int _pin) {
  this->_pin = _pin;
  init();
}

void Servo_prof.init() {
  servo.attach(_pin);
}
void Servo_prof.paper() {
  servo.write(0);
}
void Servo_prof.general_waste() {
  servo.write(90);
}
void Servo_prof.plastic() {
  servo.write(180);
}