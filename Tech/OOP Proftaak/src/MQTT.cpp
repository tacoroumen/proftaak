#include "MQTT.h"
MQTT_prof::MQTT_prof(const char *mqtt_server, int port) {
  client.setServer(mqtt_server, 1883);
}
void MQTT_prof::upload(float _weight_kg) {
  char _currentstring[8];
  dtostrf(_weight_kg, 1, 2, _currentstring);
  client.publish("fontys/weight", _currentstring);
}
void callback(char *topic, byte *message, unsigned int length)
{
  Serial.print("Message arrived on topic: ");
  Serial.print(topic);
  Serial.print(". Message: ");
  String messageTemp;

  for (int i = 0; i < length; i++)
  {
    Serial.print((char)message[i]);
    messageTemp += (char)message[i];
  }
  Serial.println();

  // Feel free to add more if statements to control more GPIOs with MQTT

  // If a message is received on the topic esp32/output, you check if the message is either "on" or "off".
  // Changes the output state according to the message
  if (String(topic) == "proftaak/fontys/command")
  {
    Serial.print("Changing output to ");
    if (messageTemp == "paper")
    {
      Serial.println("paper");
      
    }
    else if (messageTemp == "general_waste")
    {
      Serial.println("general_waste");
      
    }
    else if (messageTemp == "plastic")
    {
      Serial.println("plastic");
      
    }
  }
}
void callbackback () {
  client.setCallback(callback);
}
