using System;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    public partial class FormMeasuring : Form
    {
        Thread secondthread;
        MQTT mqttsettings = new MQTT();
        LoginInfo login = new LoginInfo();
        Products products = new Products("", "", "");
        Database database = new Database();
        private int material;
        private string username;
        private double weight;
        private string uuid;

        public FormMeasuring(int Material, string username, string uuid)
        {
            InitializeComponent();
            LabelUsername.Text = username;
            this.material = Material;
            this.username= username;
            this.uuid = uuid;
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
                if (mqttsettings.Weightvalue > 0 && !opened)
                {
                    this.weight = mqttsettings.Weightvalue;
                    FormResults formResults = new FormResults(material, this.username, this.weight, this.uuid);
                    formResults.ShowDialog();
                    opened = true;
                }
            }
        }
    }
}
