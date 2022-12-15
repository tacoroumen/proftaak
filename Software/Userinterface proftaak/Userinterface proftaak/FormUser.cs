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

        MQTT mqttsettings  = new MQTT();
        Database database = new Database();
        public FormUser()
        {
            new MqttClient(mqttsettings.HostName);
            InitializeComponent();

            TextBoxUsername.Text = mqttsettings.Client; //display the client as username, subject to change due to scanning the card
            //Get values from MQTT.cs
            database.ConnectionDatabase(); //test connection to database, mostly for test purpose right now
        }

        private void ComboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (mqttClient != null && mqttClient.IsConnected) //publishes the selected materials to the mqtt server
            //{
            //    mqttClient.Publish(mqttsettings.PathMaterials, Encoding.UTF8.GetBytes(ComboBoxMaterials.Text));
            //}
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
