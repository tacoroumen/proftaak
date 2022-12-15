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
    //form might become just the "scan pasje" and no option to choose. Whether or not the company part will get used on the device itself is unclear for now
    //prioritization lies in the User side, as this will definitely be used on the device
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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
        
    }
}
