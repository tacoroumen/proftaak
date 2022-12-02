#include "MQTT.h"
#include "Servo_prof.h"
MQTT_prof::MQTT_prof(const char *mqtt_server, int port) {
  client.setServer(mqtt_server, 1883);
}
void MQTT_prof::upload(float _weight_kg) {
  char _currentstring[8];
  dtostrf(_weight_kg, 1, 2, _currentstring);
  client.publish("fontys/weight", _currentstring);
}
void MQTT_prof::reconnect() {
  while (!client.connected())
  {
    Serial.print("Attempting MQTT connection...");
    // Attempt to connect
    if (client.connect("ESP32Client", "proftaak", "04juLi2003!"))
    {
      Serial.println("connected");
      // Subscribe
      client.subscribe("fontys/type_of_waste");
      upload();
    }
    else
    {
      Serial.print("failed, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 5 seconds");
      // Wait 5 seconds before retrying
      delay(5000);
    }
  }
}

void MQTT_prof::callback(char *topic, byte *message, unsigned int length)
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
  if (String(topic) == "fontys/type_of_waste")
  {
    Serial.print("Changing output to ");
    if (messageTemp == "paper")
    {
      Serial.println("paper");
      Servo_prof::paper();

    }
    else if (messageTemp == "general_waste")
    {
      Serial.println("general_waste");
      Servo_prof::general_waste();
      
    }
    else if (messageTemp == "plastic")
    {
      Serial.println("plastic");
      Servo_prof::plastic();
      
    }
  }
}
void MQTT_prof.callbackback () {
  client.setCallback(MQTT_prof.callback);
}
