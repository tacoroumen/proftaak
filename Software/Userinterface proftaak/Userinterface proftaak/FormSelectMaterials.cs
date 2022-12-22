using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
    
namespace Userinterface_proftaak
{
    //All values can be declared in a class and then used in the main form
    //like mqttClient = new MqttClient (HostName). public string HostName { get; set; } in class
    //Managed to do it with encapsulation and having the values declared separately
    public partial class FormSelectMaterials : Form
    {
        MQTT mqttsettings  = new MQTT();
        User login = new User("","","","");
        Products products = new Products("","","");
        Database database = new Database();

        public FormSelectMaterials()
        {
            //issue because login. is empty. the declared value is not a public get set, so it cannot be called. Must be called from login method inside of MQTT
            //new MqttClient("145.220.75.105");
            InitializeComponent();
            mqttsettings.Products(products);//define the values from products
            mqttsettings.Login(login);//define login credentials for MQTT server and the database
            database.ConnectionDatabase(); //test connection to database, mostly for test purpose right now
        }

        private void ButtonSignOut_Click(object sender, EventArgs e) //End the user session, will be renamed and remodeled later on
        { 
            Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void ButtonPlastic_Click(object sender, EventArgs e)
        {
            products.Selectedmaterial = 0;
            SelectedMaterial();
        }

        private void ButtonPaper_Click(object sender, EventArgs e)
        {
            products.Selectedmaterial = 1;
            SelectedMaterial();
        }

        private void ButtonGeneralWaste_Click(object sender, EventArgs e)
        {
            products.Selectedmaterial = 2;
            SelectedMaterial();
        }

        private void SelectedMaterial()
        {
            Hide();
            FormMeasuring formMeasuring = new FormMeasuring();
            formMeasuring.ShowDialog();
        }
    }
}