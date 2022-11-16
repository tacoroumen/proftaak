#include <SPI.h>
#include <WiFiNINA.h>
#include "arduino_secrets.h"

char ssid[] = SECRET_SSID;
char pass[] = SECRET_PASS;

const int LEDARRAY[6] = {5,6,7,8,12,13};
const int INTERVALINFO = 5000;    // interval at which to update the board information
int status = WL_IDLE_STATUS;             // the Wi-Fi radio status
int i = 0;
unsigned long previousMillisInfo = 0;     //will store last time Wi-Fi information was updated
unsigned long previousMillisLED = 0;      // will store the last time LED was updated
String hostName = "www.google.com";
int pingResult;

void setup() {
  Serial.begin(9600);
  while (!Serial);
  while (status != WL_CONNECTED) {
    Serial.print("Connecting to network: ");
    Serial.println(ssid);
    status = WiFi.begin(ssid, pass);
    // wait 10 seconds for connection:
    delay(5000);
  }
  Serial.println("Connection successful");
  Serial.println("---------------------------------------");
}

void googleping(){

  Serial.print("Pinging ");

  Serial.print(hostName);

  Serial.print(": ");

  pingResult = WiFi.ping(hostName);

  if (pingResult >= 0) {

    Serial.print("SUCCESS! RTT = ");

    Serial.print(pingResult);

    Serial.println(" ms");

  } else {

    Serial.print("FAILED! Error code: ");

    Serial.println(pingResult);

  }
  delay(5000);
}

void loop() {
  
  googleping();

  unsigned long currentMillisInfo = millis();
  if (currentMillisInfo - previousMillisInfo >= INTERVALINFO) {
    previousMillisInfo = currentMillisInfo;
    Serial.println("Board Information:");
    // print board IP
    IPAddress ip = WiFi.localIP();
    Serial.print("IP Address: ");
    Serial.println(ip);

    // print network SSID
    Serial.println();
    Serial.println("Network Information:");
    Serial.print("SSID: ");
    Serial.println(WiFi.SSID());
    // print signal strength

    long rssi = WiFi.RSSI();
    Serial.print("signal strength:");
    Serial.println(rssi);
    Serial.println("---------------------------------------");
  }
  
  unsigned long currentMillisLED = millis();
  // measure the signal strength and convert it into a time interval
  int intervalLED = WiFi.RSSI() * -10;
  // check if the time after the last blink is bigger the interval 
  if (currentMillisLED - previousMillisLED >= intervalLED) {
    previousMillisLED = currentMillisLED;
    for (i = 0; i <= 5; i++){ 
      pinMode(LEDARRAY[i], OUTPUT);
      digitalWrite(LEDARRAY[i], HIGH);
      delay(250);
      digitalWrite(LEDARRAY[i], LOW);
      delay(250);
    }
  }   
}
