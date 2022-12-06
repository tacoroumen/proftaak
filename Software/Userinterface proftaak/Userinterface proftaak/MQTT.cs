using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Userinterface_proftaak
{

    public class MQTT
    {
        public MqttClient mqttClient;
        public MQTT() 
        {
            mqttClient = new MqttClient("145.220.75.105");
            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            mqttClient.Subscribe(new string[] { "proftaak/fontys/" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            mqttClient.Connect("Yori", "proftaak", "04juLi2003!");

            //these values need to be in FormUser somehow
            //no progress made yet on this fact


            if(mqttClient != null && mqttClient.IsConnected)
            {
                MessageBox.Show("hello"); //mqtt is connected correctly, only in this class
            }
        }

        public void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            return;
            
            //ListBoxHistory.Invoke((MethodInvoker)(() => ListBoxHistory.Items.Add(message)));

        }


    }
}
