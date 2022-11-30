#include "Scale.h"
Scale::Scale(byte pin) {
  // Use 'this->' to make the difference between the
  // 'pin' attribute of the class and the 
  // local variable 'pin' created from the parameter.
  this->pin = pin;
  init();
}
void Scale::init() {
  pinMode(pin, OUTPUT);
  // Always try to avoid duplicate code.
  // Instead of writing digitalWrite(pin, LOW) here,
  // call the function off() which already does that
  off();
}
void Scale::on() {
  digitalWrite(pin, HIGH);
}
void Scale::off() {
  digitalWrite(pin, LOW);
}