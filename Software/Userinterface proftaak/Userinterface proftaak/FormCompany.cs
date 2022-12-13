using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Userinterface_proftaak
{
    public partial class FormCompany : Form
    {
        public FormCompany()
        {
            InitializeComponent();

            FormLogin obj = new FormLogin();
            bool help;
            help = obj.RadioButtonCompany.Checked;
            label3.Text = help.ToString();
            //test obj
        }
    }

}

