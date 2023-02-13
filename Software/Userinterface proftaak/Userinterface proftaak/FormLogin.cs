using System;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    public partial class FormLogin : Form
    {
        private string uuid;
        Thread secondthread; //create thread so this can be executed after the form has loaded
        DBUser dBUser= new DBUser();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            secondthread = new Thread(CheckPass);
            secondthread.Start();
        }
        
        public void CheckPass()
        {
            bool valid = false;
            bool opened = false;
            while (true)
            {
                dBUser.CardValidation(valid);
                if (dBUser.Valid == true)
                {
                    this.uuid = dBUser.uuid;
                    FormSelectMaterials formSelectMaterials= new FormSelectMaterials(dBUser.Username, this.uuid);
                    formSelectMaterials.ShowDialog();
                    opened = true; //return value to get out of while loop
                }
            }
        }
    }
}