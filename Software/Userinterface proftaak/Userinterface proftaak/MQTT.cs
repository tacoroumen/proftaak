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
    public class MQTT
    {
        //create new private values
        public string HostName { get; private set; }
        public string Client { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string PathWeight { get; private set; }
        public string PathMaterials { get; private set; }
        public string PathPrice { get; private set; }
        public string UserID { get; private set; }
        public MqttClient Mqttclient { get; private set; }
        public MQTT()
        {
            Login(); //get the values to login
        }
        public void Login()
        {
            //all information written here, could have just been declared in this single class and method, if this should be done is unclear 
            //will ask for advice whether i should do that or leave it like this
            //decided to change, can easily be reverted if needed but seemed very unnecesary

            this.HostName = "145.220.75.105";
            this.Client = "Username of the user";
            this.Username = "proftaak";
            this.Password = "04juLi2003!";
            this.PathMaterials = "fontys/material";
            this.PathWeight = "fontys/weight";
            this.PathPrice = "fontys/price";
            this.UserID = "fontys/user";

            this.Mqttclient = new MqttClient(HostName); //value created and saved in "MqttClient mqttClient"
            this.Mqttclient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            this.Mqttclient.Subscribe(new string[] { PathMaterials, PathWeight, PathPrice, UserID }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            this.Mqttclient.Connect(Client, Username, Password);
        }
        public void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);

            if (e.Topic == UserID)
            {
                MessageBox.Show(message);
            }
            if (e.Topic == PathMaterials) //Materials combobox, publish might not be needed due to possible need calculations inside software
            {
                MessageBox.Show(message);
                //can define value to use it in other forms
            }
            else if (e.Topic == PathWeight) //Measured weight
            {
                MessageBox.Show(message);

            }
            else if (e.Topic == PathPrice) //Calculated price, subject to change due to difference in materials 
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