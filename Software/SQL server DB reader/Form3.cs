using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_server_DB_reader
{
    public partial class Form3 : Form
    {
        string[] ConString = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Form3(string[] ConStringParse)
        {
            InitializeComponent();

            ConString = ConStringParse;
        }
    }
}
