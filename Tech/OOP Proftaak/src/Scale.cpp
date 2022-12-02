#include "Scale.h"
Scale::Scale(int _datapin, int _clockpin) {
  init();
}
void Scale::init() {
  scale.begin(_datapin, _clockpin);
  scale.tare();
  LoadCell.begin();
}
void Scale::calibrate() {
  LoadCell.tare();
  LoadCell.refreshDataSet();
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue);
  pinMode(_datapin, INPUT);
  pinMode(_clockpin, OUTPUT);
}

int Scale::measure() {
  _weight = scale.get_units(10);
  _weight_kg = _weight / 1000;
  return _weight_kg;
}
