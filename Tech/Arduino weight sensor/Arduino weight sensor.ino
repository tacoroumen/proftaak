#include <HX711.h>
#include <HX711_ADC.h>

HX711 scale;
const int CLOCKPIN = 4;
const int DATAPIN = 5; 
const int ARRAYLENGTH = 10;
int i = 0;
double pricearray[ARRAYLENGTH] = {};
double price = 0;
double weight = 0;
double total_weight = 0;
double total_price = 0;
unsigned long t = 0;
String value;

HX711_ADC LoadCell(DATAPIN, CLOCKPIN);

void setup(){
  Serial.begin(57600);
  scale.begin(DATAPIN, CLOCKPIN);
  scale.tare();
  LoadCell.begin();
  Serial.println("Please remove all mass from the scale");
  Serial.print('\n');
  delay(3000);

  calibrate(); //start calibration
}



void calibrate() {
  Serial.println("Calibration start");
  LoadCell.refreshDataSet(); //refresh the dataset to be sure that the known mass is measured correct
  float newCalibrationValue = 459.36;
  scale.set_scale(newCalibrationValue); 
  delay(500);
  Serial.println("Calibration finished");
  delay(1000);
  Serial.print('\n');
  Serial.println("Please put the object you want to measure on the scale");
}

void priceofplastic(){
  price = weight / 1000 * 0.75;
  Serial.print('\n');
  Serial.print("price: ");
  Serial.print(price);
  Serial.print(" euro");
  Serial.print('\n');
  
  total_price = total_price + price;     
  Serial.print("Total price: ");
  Serial.print(total_price);
  Serial.print(" euro");
  Serial.println('\n');
}


void measurements(){
  weight = scale.get_units(10);
  total_weight = total_weight + weight;  
  Serial.print('\n');
  Serial.print("Weight: ");   
  Serial.print(weight); 
  Serial.print(" grams");
  Serial.print('\n'); 

  Serial.print("Total weight: ");
  Serial.print(total_weight);
  Serial.print(" grams");

  priceofplastic(); //measure and print the price of the measured object

  delay(1500);
  Serial.println("Please remove said object from the scale");
  delay(3000);
  Serial.print('\n');

  serialread();
}
void serialread(){
  Serial.println("Do you wish to continue measuring?");
  Serial.println("Send 'yes' if you wish to continue and 'no' if you wish to stop");

  if (Serial.available() > 0){
    char received = Serial.read();
    if (received == '\n'){
      if (value == "yes"){
        Serial.println("yes");
        value = "";
      }
      if (value == "no"){
        Serial.println("no");
        value = "";
      }
    }else {
      value += received; 
    }
  } 
}


void loop(){
  weight = scale.get_units(10);      
  if (weight > 1){
    measurements(); //Function to measure weight once.
  }
}


//0.75 cent per kilo