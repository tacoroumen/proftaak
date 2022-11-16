#include <ulog_sqlite.h>
#include <SPI.h>
#include <WiFiNINA.h>
#include "Arduino_Secrets.h"

char ssid[] = SECRET_SSID;
char pass[] = SECRET_PASS;
char Username[] = SECRET_USERNAME;
char Password[] = SECRET_PASSWORD;
const char SERVER[] = "192.168.160.210";
const int LEDARRAY[6] = {5,6,7,8,12,13};
int status = WL_IDLE_STATUS;  
int pingResult; 
int i = 0;
unsigned long previousMillisInfo = 0; 
unsigned long previousMillisLED = 0;    
String data;
WiFiSSLClient client;
WiFiServer server(443);

void googleping(){
  IPAddress ip = WiFi.localIP();
  Serial.print("IP Address: ");
  Serial.println(ip);
  Serial.print("Pinging ");
  Serial.print("server");
  Serial.print(": ");
  pingResult = WiFi.ping(SERVER);
  
  if (pingResult >= 0) {

    Serial.print("SUCCESS! RTT = ");

    Serial.print(pingResult);

    Serial.println(" ms");

  } else {

    Serial.print("FAILED! Error code: ");

    Serial.println(pingResult);
    client.println("bitch");
  }
  delay(5000);
}

void setup() {
  Serial.begin(9600);
  while (!Serial);
  while (status != WL_CONNECTED) {
    Serial.print("Connecting to network: ");
    Serial.println(ssid);
    status = WiFi.begin(ssid, pass);
    // wait 5 seconds for connection:
    delay(5000);
  }
  Serial.println("Connection successful");
  if (client.connect(SERVER, 443)) {
    Serial.println("connected to server");
    // Make a HTTP request:
    client.println("GET /search?q=arduino HTTP/1.1");
    client.println("Host: 192,168,160,210");
    client.println("Connection: close");
    client.println();
  }
}

void loop() {
  googleping();
  WiFiClient client = server.available();
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
