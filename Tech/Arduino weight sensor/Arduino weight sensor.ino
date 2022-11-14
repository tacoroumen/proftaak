#include <HX711.h>
#include <HX711_ADC.h>


/*NOTES
total wordt groter als de price boven total komt, anders niet. De massa wordt hier niet goed gerekend.
Dit is een probleem want de treshold wordt steeds groter en groter.
Niet functioneel zoals het moet werken.
*/

HX711 scale;
const int CLOCKPIN = 4;
const int DATAPIN = 5; 
const int ARRAYLENGTH = 10;
int i = 0;
double pricearray[ARRAYLENGTH] = {};
double price = 0;
double weight = 0;
double total = 0;
unsigned long t = 0;
HX711_ADC LoadCell(DATAPIN, CLOCKPIN);

void setup(){
  Serial.begin(57600);
  scale.begin(DATAPIN, CLOCKPIN);
  scale.tare();


  LoadCell.begin();
  unsigned long stabilizingtime = 2000; 
  boolean tare = true; 
  LoadCell.start(stabilizingtime, tare);
  if (LoadCell.getTareTimeoutFlag() || LoadCell.getSignalTimeoutFlag()) {
    Serial.println("Timeout, check MCU>HX711 wiring and pin designations");
    while (1);
  }
  else {
    LoadCell.setCalFactor(1.0); 
    Serial.println("Startup is complete");
  }
  while (!LoadCell.update());

  calibrate(); //start calibration
}



void calibrate() {
  Serial.println("Start calibration:");
  Serial.println("Remove all objects from the scale.");
  Serial.println("Send 't' from serial monitor to set the tare offset.");
  boolean resume = false;
  while (resume == false) {
    LoadCell.update();
    if (Serial.available() > 0) {
      if (Serial.available() > 0) {
        char inByte = Serial.read();
        if (inByte == 't') LoadCell.tareNoDelay();
      }
    }
    if (LoadCell.getTareStatus() == true) {
      Serial.println("Tare complete");
      resume = true;
    }
  }

  Serial.println("Place your known mass on the loadcell.");
  Serial.println("Send the weight of this mass in grams from the serial monitor.");

  float known_mass = 0;
  resume = false;
  while (resume == false) {
    LoadCell.update();
    if (Serial.available() > 0) {
      known_mass = Serial.parseFloat();
      if (known_mass != 0) {
        Serial.print("Known mass is: ");
        Serial.println(known_mass);
        resume = true;
      }
    }
  }
  LoadCell.refreshDataSet(); //refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = LoadCell.getNewCalibration(known_mass); //get the new calibration value


  scale.set_scale(newCalibrationValue); 
}

void priceofplastic(){
  price = weight / 1000 * 0.75;
  Serial.println();
  Serial.print("price: ");
  Serial.print(price);
  Serial.print(" euro");

  pricearray[i] = price;

  if (pricearray[i] > pricearray[i - 1]){
    total = total + pricearray[i];     
    i++;
  }
  if (i = 10){
    i = 0;
  }
  Serial.println();
  Serial.print("Total: ");
  Serial.print(total);
  Serial.print(" euro");
  Serial.println("");
}

void loop(){
  weight = scale.get_units(10);
  delay(500);        
  if (weight > 0){
    Serial.println("");
    Serial.print("Weight: ");   
    Serial.print(weight); 
    Serial.print(" gram");
    priceofplastic();
  }
  delay(500);
}


//0.75 cent per kilo