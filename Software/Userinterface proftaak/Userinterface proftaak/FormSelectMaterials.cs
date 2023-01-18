using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    public partial class FormSelectMaterials : Form
    {
        MQTT mqttsettings = new MQTT();
        Products products = new Products("","","");
        LoginInfo login = new LoginInfo();
        Database database = new Database();
        public string selectedMaterials;
        private int material;
        private string username;
        private string uuid;
        public FormSelectMaterials()
        {
            InitializeComponent();
            mqttsettings.Products(products);//define the values from products
            mqttsettings.Login(login);//define login credentials for MQTT server and the database
            database.ConnectionDatabase(); //test connection to database, mostly for test purpose right now
        }

        public FormSelectMaterials(string username, string uuid) : this() //constructor chaining so that FormSelectMaterials() also gets executed
        {
            this.username = username;
            this.uuid = uuid;
            LabelUsername.Text = this.username;
        }

        private void ButtonSignOut_Click(object sender, EventArgs e) //End the user session, will be renamed and remodeled later on
        {
            Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void ButtonPlastic_Click(object sender, EventArgs e)
        {
            material = (int)MaterialType.Plastic; //not functional
            mqttsettings.SelectedMaterial((int)MaterialType.Plastic);
            SelectedMaterial();
        }

        private void ButtonPaper_Click(object sender, EventArgs e)
        {
            material = (int)MaterialType.Paper; //not functional
            mqttsettings.SelectedMaterial((int)MaterialType.Paper);
            SelectedMaterial();
        }

        private void ButtonGeneralWaste_Click(object sender, EventArgs e)
        {
            material = (int)MaterialType.GeneralWaste; //not functional
            mqttsettings.SelectedMaterial((int)MaterialType.GeneralWaste);
            SelectedMaterial();
        }

        private void SelectedMaterial()
        {
            Hide();
            FormMeasuring formMeasuring = new FormMeasuring(material, this.username, this.uuid);
            formMeasuring.ShowDialog();
        }
    }
}