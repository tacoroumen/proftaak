using System;
using System.Threading;
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
        private int Material;

        public FormMeasuring(int Material)
        {
            InitializeComponent();
            LabelUsername.Text = database.Username;
            this.Material = Material;
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
                    // MessageBox.Show(mqttsettings.weightvalue);
                    FormResults formResults = new FormResults(Material);
                    formResults.ShowDialog();
                    opened = true;
                }
            }
        }
    }
}
