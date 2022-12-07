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
            if (RadioButtonUser.Checked == true)
            {
                Hide();
                FormUser FormUser = new FormUser();
                FormUser.ShowDialog();
            }
            else
            {
                //might be obsolete due to the "mobile" app
                Hide();
                FormCompany FormCompany = new FormCompany();
                FormCompany.ShowDialog();
            }
        }
        
    }
}
