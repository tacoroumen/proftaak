using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_server_DB_reader
{
    public partial class Form2 : Form
    {
        string[] ConString = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Form2(string[] ConStringParse)
        {
            InitializeComponent();
            ConString = ConStringParse;

            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }

            SqlConnection conn = new SqlConnection(ConStringFull);
            conn.Open();
            string query = "SELECT * FROM SYSOBJECTS WHERE xtype = 'U'; ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["Tables_in_" + ConString[3]]);
            }
            conn.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }

            SqlConnection conn = new SqlConnection(ConStringFull);
            conn.Open();
            string query = "DESCRIBE " + TableComboBox.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["Field"]);
            }
            conn.Close();
        }
    }
}

