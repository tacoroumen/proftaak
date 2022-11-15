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
unsigned long time_1 = 0;


int period = 500;
unsigned long time_now = 0;

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

  time_now = millis();

  while(millis() < time_now + period){
    int random = 1 + (rand() % 3);
    if (random = 1){
      Serial.print("-----");
    }else if (random = 2){
      Serial.print("---");
    }else if (random = 3){
      Serial.print("-");
    }
  }
  // delay(500);
  // Serial.print("-----");
  // delay(500);
  // Serial.print("-----");
  // delay(500);
  // Serial.print("-----");
  // delay(500);
  // Serial.print("-----");
  LoadCell.refreshDataSet(); //refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue); 
  delay(1500);
  Serial.println();
  Serial.println("Calibration finished");
  delay(500);
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