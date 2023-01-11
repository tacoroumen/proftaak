using System;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    //All values can be declared in a class and then used in the main form
    //like mqttClient = new MqttClient (HostName). public string HostName { get; set; } in class
    //Managed to do it with encapsulation and having the values declared separately
    public partial class FormSelectMaterials : Form
    {
        MQTT mqttsettings = new MQTT();
        Products products = new Products("","","");
        LoginInfo login = new LoginInfo();
        Database database = new Database();
        public string Selectedmaterials;
        private int Material;

        public FormSelectMaterials()
        {
            //issue because login. is empty. the declared value is not a public get set, so it cannot be called. Must be called from login method inside of MQTT
            //new MqttClient("145.220.75.105");
            InitializeComponent();
            mqttsettings.Products(products);//define the values from products
            mqttsettings.Login(login);//define login credentials for MQTT server and the database
            database.ConnectionDatabase(); //test connection to database, mostly for test purpose right now
            LabelUsername.Text = database.Username;
        }

        private void ButtonSignOut_Click(object sender, EventArgs e) //End the user session, will be renamed and remodeled later on
        {
            Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void ButtonPlastic_Click(object sender, EventArgs e)
        {
            Material = (int)MaterialType.Plastic; //not functional
            MessageBox.Show(((int)MaterialType.Plastic).ToString());
            SelectedMaterial(Material);
        }

        private void ButtonPaper_Click(object sender, EventArgs e)
        {
            Material = (int)MaterialType.Paper; //not functional
            SelectedMaterial(Material);
        }

        private void ButtonGeneralWaste_Click(object sender, EventArgs e)
        {
            Material = (int)MaterialType.GeneralWaste; //not functional
            SelectedMaterial(Material);
        }

        private void SelectedMaterial(int Material)
        {
            new Products(Material); //change Selectedmaterial to Material
            Hide();
            FormMeasuring formMeasuring = new FormMeasuring();
            formMeasuring.ShowDialog();
        }
    }
}