using System;
using System.Threading;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    public partial class FormLogin : Form
    {
        Thread secondthread; //create thread so this can be executed after the form has loaded
        LoginInfo login = new LoginInfo();
        Products products = new Products("", "", "");
        MQTT mqttsettings = new MQTT();
        Database database = new Database();
        DBUser dBUser= new DBUser();

        //Need to login to MQTT to get the scanned ID from the card
        //Need to login to database and run the query to validate said card

        public FormLogin()
        {
            InitializeComponent();


            //mqttsettings.Products(products);//define the values from products
            //mqttsettings.Login(login);//define login credentials for MQTT server and the database
            //cannot even use values in other classes. DBUser is completely shut out when I do not login only there.
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            secondthread = new Thread(CheckPass);
            secondthread.Start();
        }
        
        public void CheckPass()
        {
            bool opened = false;
            while (true)
            {
                dBUser.CardValidation();
                bool valid = database.Valid;
                if (valid)
                {
                    FormSelectMaterials FormUser = new FormSelectMaterials();
                    FormUser.ShowDialog();
                    opened = true; //return value to get out of while loop
                }
            }
        }
    }
}