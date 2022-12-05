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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonScan_Click(object sender, EventArgs e)
        {
            if (RadioButtonCompany.Checked == true)
            {
                Hide();
                FormCompany FormCompany = new FormCompany();
                FormCompany.ShowDialog();
            }
            else
            {
                Hide();
                FormUser FormUser = new FormUser();
                FormUser.ShowDialog();
            }
        }
        
    }
}
