using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Userinterface_proftaak
{

    //FAILED TO GET IT WORKING
    //POSSIBLE WORKAROUND. All values can be declared in a class and then used in the main form.
    //like mqttClient = new MqttClient (HostName). public string HostName { get; private set; } (to make it read only) in class

    public class MQTT
    { 
        public string HostName { get; private set; }
        public string Client { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mqtt_Path { get; private set; }

        public MqttClient mqttClient;

        public MQTT()
        {
            this.HostName = "145.220.75.105";
            this.Client = "Yori";
            this.Username = "proftaak";
            this.Password = "04juLi2003!";
            this.Mqtt_Path = "proftaak/fontys/";
        }
    }
}
