using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Userinterface_proftaak
{
    internal class MQTT
    {
        //create new private values
        //values separated in classses and objects

        public MqttClient Mqttclient { get; private set; }
        public string Cardnumber { get; private set; }
        public string Pricevalue { get; private set; }
        public double Weightvalue { get; private set; }

        //have to declare these v alues as using the default values like price and weight will not give output back

        private string hostname;
        private string client;
        private string username;
        private string password;
        private string useridcard;

        private string price;
        private string weight;
        private string materials;

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

//variable gewicht, zelf veranderen in software
//time out signed in as 30 sec
//time out measuring 30 sec
//summ form 

//datum legen uitlezen 
//subquery met dat de datum groter moet zijn dan dat 
//fontys/status   message = Done als klaar en = Busy als uid vergeleken is in database en een valide waarde heeft
//popup als niet goed is-> card not recognized en status = Denied 

//data encryption