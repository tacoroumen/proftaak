using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Userinterface_proftaak
{
    public partial class FormUser : Form
    {
        MqttClient mqttClient;

        public FormUser()
        {
            InitializeComponent();

            Task.Run(() =>
            {
                mqttClient = new MqttClient("145.220.75.105");
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                mqttClient.Subscribe(new string[] { "proftaak/fontys/" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                mqttClient.Connect("Yori", "proftaak", "04juLi2003!");
            });
        }
        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            ListBoxHistory.Invoke((MethodInvoker)(() => ListBoxHistory.Items.Add(message)));

        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    mqttClient.Publish("proftaak/fontys/", Encoding.UTF8.GetBytes("help"));

                }
            });
        }
    }
}
