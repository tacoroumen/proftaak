using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhpMyAdmin_read_and_visualize
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    someControlOnForm1.Text = form2.TheValue;
                }
            }
        }

        
    }
}
