using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace Userinterface_proftaak
{
    public partial class FormMeasuring : Form
    {
        Thread secondthread;
        MQTT mqttsettings = new MQTT();
        User login = new User("", "", "", "");
        Products products = new Products("", "", "");

        public FormMeasuring()
        {
            InitializeComponent();
        }

        private void FormMeasuring_Load(object sender, EventArgs e)
        {
            secondthread = new Thread(CheckWeight);
            secondthread.Start();
        }

        private void CheckWeight()
        {
            mqttsettings.Products(products);
            mqttsettings.Login(login);
            bool opened = false;
            while (true)
            {
                if (mqttsettings.weightvalue != null && !opened)
                {
                    MessageBox.Show(mqttsettings.weightvalue);
                    FormResults formResults = new FormResults();
                    formResults.ShowDialog();
                    opened = true;
                }
            }
        }
    }
}
