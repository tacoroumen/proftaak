using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Userinterface_proftaak
{
    public partial class FormResults : Form
    {
        Thread secondthread;
        MQTT mqttsettings = new MQTT();
        User login = new User("", "", "", "");
        Products products = new Products("", "", "");

        delegate void SetTextCallback(string text);

        public FormResults()
        {
            InitializeComponent();
        }
        private void FormResults_Load(object sender, EventArgs e)
        {
            secondthread = new Thread(SelectedMaterials);
            secondthread.Start();
        }

        private void SelectedMaterials()
        {
            SelectedMaterial();
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
                }
                else if (products.Selectedmaterial == 1)
                {
                    text = "Paper";
                    this.LabelMaterial.Text = text;
                }
                else if (products.Selectedmaterial == 2)
                {
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

        private void SelectedMaterial()
        {
            string text = "";
            SetTextMaterial(text);
        }

        private void WeightValue()
        {
            SetTextWeight(mqttsettings.weightvalue);
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
