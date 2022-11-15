#include <Arduino.h>
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
  Serial.println("Please remove all mass from the scale");
  delay(3000);
  LoadCell.begin();
  calibrate(); //start calibration
}



void calibrate() {
  Serial.println("Calibration start");
  for(unsigned long time_now; millis() < (millis()+ 100); time_now = millis()){
    Serial.println("Loading... ");
    int random_int = random_int + random(1, 18);
    if (random_int >=100){
      random_int = 100;
      return;
    }
    Serial.print(random_int);
    Serial.print("%");
    
  }
  LoadCell.refreshDataSet(); //refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue); 
  Serial.println();
  Serial.println("Calibration finished");
  delay(200);
  Serial.println("Mass can now be placed");
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