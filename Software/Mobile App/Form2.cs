using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_App
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();

            Location = new Point(50, 50);
        }

        private void CloseForm2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
