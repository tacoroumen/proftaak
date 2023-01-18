using System;
using System.Threading;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    public partial class FormResults : Form
    {
        Thread secondthread;
        MQTT mqttsettings = new MQTT();
        LoginInfo login = new LoginInfo();
        Products products = new Products("", "", "");
        DBUser dBUser= new DBUser();
        private double weight;
        private string uuid;
        private string username;
        private string status;
        delegate void SetTextCallback(string text);

        public FormResults(int Material, string username, double weight, string uuid)
        {
            InitializeComponent();
            LabelUsername.Text = username;
            this.username= username;
            this.weight = weight;
            this.uuid = uuid;
            products.SetMaterial(Material);
        }
        private void FormResults_Load(object sender, EventArgs e)
        {
            secondthread = new Thread(Materials);
            secondthread.Start();
        }

        private void Materials()
        {
            mqttsettings.Products(products);
            mqttsettings.Login(login);
            ChosenMaterial();
        }

        private void SetTextMaterial(string text)
        {
            if (this.LabelMaterial.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextMaterial);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (products.Selectedmaterial == 0)
                {
                    text = this.weight + " KG"  + " Paper";
                    this.LabelMaterial.Text = text;
                }
                else if (products.Selectedmaterial == 1)
                {
                    text = this.weight + " KG" + " Paper";
                    this.LabelMaterial.Text = text;
                }
                else if (products.Selectedmaterial == 2)
                {
                    text = this.weight + " KG" + " General Waste";
                    this.LabelMaterial.Text = text;
                }
            }
        }

        private void ChosenMaterial()
        {
            string text = "";
            SetTextMaterial(text);
        }

        private void ButtonSignOut_Click(object sender, EventArgs e)
        {
            dBUser.DatabaseInsert(this.uuid, this.weight, products.Selectedmaterial);
            this.status = "Done";
            mqttsettings.StatusChecked(this.status);
            Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            dBUser.DatabaseInsert(this.uuid, this.weight, products.Selectedmaterial);
            this.status = "Busy";
            mqttsettings.StatusChecked(this.status);
            Hide();
            FormSelectMaterials formselectmaterials = new FormSelectMaterials(this.username, this.uuid);
            formselectmaterials.ShowDialog();
        }
    }
}
