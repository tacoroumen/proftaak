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
    public partial class ChooseUpload : Form
    {
        public ChooseUpload()
        {
            InitializeComponent();
        }

        private void SqlButton_Click(object sender, EventArgs e)
        {
            SqlInsert form1 = new SqlInsert();
            form1.ShowDialog();
        }

        private void MqttButton_Click(object sender, EventArgs e)
        {

        }
    }
}
