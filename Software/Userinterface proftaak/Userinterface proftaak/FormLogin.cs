using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Userinterface_proftaak
{
    //form might becom
    //e just the "scan pasje" and no option to choose. Whether or not the company part will get used on the device itself is unclear for now
    //prioritization lies in the User side, as this will definitely be used on the device
    public partial class FormLogin : Form
    {
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
        
        private void ButtonScan_Click(object sender, EventArgs e)
        {
            //will be replaced completely due to scanning a card, no button or anything will be needed
            //database class will be called to determine whether or not the card being scanned is in the database and is legit
            if (RadioButtonUser.Checked == true)
            {
                Hide();
                FormUser FormUser = new FormUser();
                FormUser.ShowDialog();
            }
        }


        //attempt to create it so that the form is shown at all times and no button input or anything is required to make it change forms, design wants this
        private void Buttoncheck()
        {
            if (RadioButtonUser.Checked == true)
            {
                while (mqttsettings.cardnumber == null)
                {
                    if (mqttsettings.cardnumber != null)
                    {
                        MessageBox.Show(mqttsettings.cardnumber);
                        Hide();
                        FormUser FormUser = new FormUser();
                        FormUser.ShowDialog();
                        return;
                    }
                }
            }
        }
    }
}
