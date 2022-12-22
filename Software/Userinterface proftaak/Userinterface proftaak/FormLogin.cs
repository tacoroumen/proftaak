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
using System.Windows.Forms.VisualStyles;
using uPLibrary.Networking.M2Mqtt;

namespace Userinterface_proftaak
{
    public partial class FormLogin : Form
    {
        Thread secondthread; //create thread so this can be executed after the form has loaded
        MQTT mqttsettings = new MQTT();
        User login = new User("", "", "", "");
        Products products = new Products("", "", "");
        Database database = new Database();
        //Need to login to MQTT to get the scanned ID from the card
        //Need to login to database and run the query to validate said card

        public FormLogin()
        {
            InitializeComponent();
            mqttsettings.Products(products);//define the values from products
            mqttsettings.Login(login);//define login credentials for MQTT server and the database
            database.ConnectionDatabase(); //test connection to database, mostly for test purpose right now
        }

        private  void FormLogin_Load(object sender, EventArgs e)
        {
            secondthread = new Thread(CheckPass); 
            secondthread.Start();
        }

        private void CheckPass()
        {
            bool opened = false;
            while (true)
            {
                if (mqttsettings.Cardnumber == "74103157" && !opened)
                {
                    FormSelectMaterials FormUser = new FormSelectMaterials();
                    FormUser.ShowDialog();
                    opened = true; //return value to get out of while loop
                }
                else if (mqttsettings.Cardnumber == "434119273")
                {
                    MessageBox.Show("Invalid card");
                }
            }
        }
    }
}
