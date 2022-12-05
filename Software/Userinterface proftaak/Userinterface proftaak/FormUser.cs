using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace Userinterface_proftaak
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();


            FormLogin obj = new FormLogin();
            bool help;
            help = obj.RadioButtonCompany.Checked;
            ListBoxHistory.Items.Add(help.ToString());
            //testing with radiobutton to display the correct form
        }
        public MqttClient mqttClient;
            //always null, needs to change to be able to connect
        MQTT test = new MQTT();
        
        //connects to MQTT server correctly, does not do the message yet
        //dont know how to get values from this to use in the button


        public void ButtonStart_Click(object sender, EventArgs e)
        {
            //button for testing purpose, part of devkit
            if (mqttClient != null && mqttClient.IsConnected)
            {
                 mqttClient.Publish("proftaak/fontys/", Encoding.UTF8.GetBytes("help"));
            }
        }
    }
}
