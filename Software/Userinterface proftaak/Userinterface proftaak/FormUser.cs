using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Userinterface_proftaak
{
    //POSSIBLE WORKAROUND. All values can be declared in a class and then used in the main form
    //like mqttClient = new MqttClient (BrokerHostName). public string BrokerHostName { get; set; } in class
    //workaround used and it works :) although not as I preferred to have it work
    //Managed to do it with encapsulation and having the values declared separately

    //Value needs to be saved in memory, otherwise the code will run once and not save anything it does
    public partial class FormUser : Form
    {
        MqttClient mqttClient; //saved value
        MQTT mqttsettings = new MQTT();

        public FormUser()
        {
            InitializeComponent();

            this.mqttClient = new MqttClient(mqttsettings.HostName); //value created and saved in "MqttClient mqttClient"
            this.mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            this.mqttClient.Subscribe(new string[] { mqttsettings.Mqtt_Path }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            this.mqttClient.Connect(mqttsettings.Client, mqttsettings.Username, mqttsettings.Password);
            //Get values from MQTT.cs

            FormLogin obj = new FormLogin();
            bool help;
            help = obj.RadioButtonCompany.Checked;
            ListBoxHistory.Items.Add(help.ToString());
            //testing with radiobutton to display the correct form
            //gives the correct form, yet it displays "false" while this should be "true"
            //the button is never saved anywhere so it will not give a value, to get the value, it needs to be saved in the FormLogin and extracted with variables
        }

        //connects to MQTT server correctly, does not do the message yet
        //dont know how to get values from this to use in the button

        public void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            ListBoxHistory.Invoke((MethodInvoker)(() => ListBoxHistory.Items.Add(message)));
        }
        public void ButtonStart_Click(object sender, EventArgs e)
        {
            //button for testing purpose, part of devkit
            if (mqttClient != null && mqttClient.IsConnected)
            {
                mqttClient.Publish(mqttsettings.Mqtt_Path, Encoding.UTF8.GetBytes(ComboBoxMaterials.Text));
            }
        }
    }
}
