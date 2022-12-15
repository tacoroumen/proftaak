using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
    
namespace Userinterface_proftaak
{
    //All values can be declared in a class and then used in the main form
    //like mqttClient = new MqttClient (BrokerHostName). public string HostName { get; set; } in class
    //Managed to do it with encapsulation and having the values declared separately
    public partial class FormUser : Form
    {
        int weight = 0; //global value to measure the weight
        //total weight will be extracted from the database

        MqttClient mqttClient; //saved value
        MQTT mqttsettings  = new MQTT();
        Database database = new Database();
        public FormUser()
        {
            InitializeComponent();
            this.mqttClient = new MqttClient(mqttsettings.HostName); //value created and saved in "MqttClient mqttClient"
            this.mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            this.mqttClient.Subscribe(new string[] { mqttsettings.PathMaterials, mqttsettings.PathWeight, mqttsettings.PathPrice, mqttsettings.UserID }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            this.mqttClient.Connect(mqttsettings.Client, mqttsettings.Username, mqttsettings.Password);
            TextBoxUsername.Text = mqttsettings.Client; //display the client as username, subject to change due to scanning the card
            //Get values from MQTT.cs
            database.ConnectionDatabase(); //test connection to database, mostly for test purpose right now
        }

        public void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            //Separate the values to get a singular message instead of all 3
            var message = Encoding.UTF8.GetString(e.Message);
            
            if (e.Topic == mqttsettings.UserID)
            {
                TextBoxUserID.Invoke((MethodInvoker)(() => TextBoxUserID.Text = message));
            }
            if (e.Topic == mqttsettings.PathMaterials) //Materials combobox, publish might not be needed due to possible need calculations inside software
            {
                ListBoxHistory.Invoke((MethodInvoker)(() => ListBoxHistory.Items.Add(message)));
            }
            else if(e.Topic == mqttsettings.PathWeight) //Measured weight
            {
                TextBoxWeight.Invoke((MethodInvoker)(() => TextBoxWeight.Text = message));
            }
            else if (e.Topic == mqttsettings.PathPrice) //Calculated price, subject to change due to difference in materials 
            {                                                //Own calculation inside software might be necessary instead of technology
                TextBoxPrice.Invoke((MethodInvoker)(() => TextBoxPrice.Text = message));
            }
            //listbox and textboxes for testing purposes
        }

        private void ComboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mqttClient != null && mqttClient.IsConnected) //publishes the selected materials to the mqtt server
            {
                mqttClient.Publish(mqttsettings.PathMaterials, Encoding.UTF8.GetBytes(ComboBoxMaterials.Text));
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e) //End the user session, will be renamed and remodeled later on
        {
            Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }
    }
}

//show weight to user 
