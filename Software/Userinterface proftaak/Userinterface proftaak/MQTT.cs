using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Userinterface_proftaak
{
    internal class MQTT
    {
        private string hostname;
        private string client;
        private string username;
        private string password;
        private string useridcard;

        private string price;
        private string weight;
        private string materials;

        private int selectedMaterials = -1;
        private string status;

        public MqttClient Mqttclient { get; private set; }
        public string Cardnumber { get; private set; }
        public string Pricevalue { get; private set; }
        public double Weightvalue { get; private set; }

        public void Login(LoginInfo logininfo)
        {
            LoginInfo userid = new LoginInfo("");//define userid from the scanned card
            this.hostname = logininfo.MQTTHostname;
            this.client = logininfo.MQTTClient;
            this.username = logininfo.MQTTUsername;
            this.password = logininfo.MQTTPassword;

            this.useridcard = userid.UserIDPath;

            this.Mqttclient = new MqttClient(hostname); //value created and saved in "MqttClient Mqttclient"
            this.Mqttclient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            this.Mqttclient.Subscribe(new string[] { this.materials, this.weight, this.price, this.useridcard }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            this.Mqttclient.Connect(this.client, this.username, this.password); //server connection
        }

        public void Products(Products products)
        {
            this.price = products.PricePath;
            this.materials = products.MaterialsPath;
            this.weight = products.WeightPath;
        }

        public void SelectedMaterial(int selectedmaterial)
        {
            this.selectedMaterials = selectedmaterial;
            Mqttclient.Publish("fontys/material", Encoding.UTF8.GetBytes(this.selectedMaterials.ToString()));
        }

        public void StatusChecked(string status)
        {
            this.status = status;
            this.Mqttclient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            Mqttclient.Publish("fontys/status", Encoding.UTF8.GetBytes(this.status.ToString()));
        }

        public void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);

            if (e.Topic == this.useridcard)
            {
                //MessageBox.Show(message);
                Cardnumber = message;
            }
            else if (e.Topic == this.weight) //Measured weight
            {
                Weightvalue = Convert.ToDouble(message);
            }
            else if (e.Topic == this.price) //Calculated price, subject to change due to difference in materials 
            {
                Pricevalue = message;
            }
        }
    }
}
