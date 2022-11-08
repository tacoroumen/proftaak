using MySql.Data.MySqlClient;
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
        string[] ConString;

        public Form2()
        {
            InitializeComponent();

            using (Form1 form1 = new Form1())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    ConString = form1.TheValue;
                }
            }

            MySqlConnection conn = new MySqlConnection(ConString[0] + ConString[1] + ConString[2]);
            conn.Open();
            string query = "SHOW TABLES FROM Proftaak";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["Tables_in_Proftaak"]);
            }
            conn.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConString[0] + ConString[1] + ConString[2]);
            conn.Open();
            string query = "DESCRIBE " + TableComboBox.Text;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["Field"]);
            }
            conn.Close();
        }
    }
}
