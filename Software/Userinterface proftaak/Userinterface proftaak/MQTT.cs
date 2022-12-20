using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Userinterface_proftaak
{
    internal class MQTT
    {
        //create new private values
        //values separated in classses and objects

        
        public MqttClient Mqttclient { get; private set; }
        public string cardnumber { get; private set; }

        private string hostname;
        private string client;
        private string username;
        private string password;
        private string useridcard;

        private string price;
        public string materials;
        private string weight;
       

        public void Login(User logininfo)
        {
            User userid = new User("");//define userid from the scanned card
            this.hostname = logininfo.MQTTHostName;
            this.client = logininfo.MQTTClient;
            this.username = logininfo.MQTTUsername;
            this.password = logininfo.MQTTPassword;

            this.useridcard = userid.UserIDCard;

            this.Mqttclient = new MqttClient(hostname); //value created and saved in "MqttClient Mqttclient"
            this.Mqttclient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            this.Mqttclient.Subscribe(new string[] { this.materials, this.weight, this.price, this.useridcard }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            this.Mqttclient.Connect(this.client, this.username, this.password);
        }

        public void Products(Products products)
        {
            this.price = products.Price;
            this.materials = products.Materials;
            this.weight = products.Weight;

        }

        public void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);

            if (e.Topic == this.useridcard)
            {
                MessageBox.Show(message);
                cardnumber = message;

                //can define value to use it in other forms
            }
            if (e.Topic == this.materials) //Materials combobox, publish might not be needed due to possible need calculations inside software
            {
                MessageBox.Show(message);
                materials = message;

            }
            else if (e.Topic == this.weight) //Measured weight
            {
                MessageBox.Show(message);

            }
            else if (e.Topic == this.price) //Calculated price, subject to change due to difference in materials 
            {                                                //Own calculation inside software might be necessary instead of technology
                MessageBox.Show(message);
            }
            //listbox and textboxes for testing purposes
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