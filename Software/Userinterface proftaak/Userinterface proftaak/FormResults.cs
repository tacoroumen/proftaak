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
        Database database= new Database();

        delegate void SetTextCallback(string text);

        public FormResults()
        {
            InitializeComponent();
            LabelUsername.Text = database.Username;
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
                    text = "Plastic";
                    this.LabelMaterial.Text = text;
                    MessageBox.Show("plastic");
                }
                else if (products.Selectedmaterial == 1)
                {
                    text = "Paper";
                    this.LabelMaterial.Text = text;
                    MessageBox.Show("Paper");
                }
                else if (products.Selectedmaterial == 2)
                {
                    MessageBox.Show("general waste");
                    this.LabelKG.Hide();
                    this.LabelMaterial.Hide();
                    this.LabelWeight.Hide();

                    this.LabelGeneralWaste.Show();
                    this.LabelKGGeneralWaste.Show();
                    this.LabelWeightGeneralWaste.Show();
                }
            }
            WeightValue();
        }

        private void SetTextWeight(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.LabelWeight.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextWeight);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.LabelWeight.Text = text;
                this.LabelWeightGeneralWaste.Text = this.LabelWeight.Text;
                this.LabelGeneralWaste.Hide();
                this.LabelKGGeneralWaste.Hide();
                this.LabelWeightGeneralWaste.Hide();
            }
        }

        private void ChosenMaterial()
        {
            string text = "";
            SetTextMaterial(text);
        }

        private void WeightValue()
        {
            SetTextWeight(mqttsettings.Weightvalue.ToString());
        }
        private void ButtonSignOut_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            Hide();
            FormSelectMaterials formselectmaterials = new FormSelectMaterials();
            formselectmaterials.ShowDialog();
        }
    }
}
