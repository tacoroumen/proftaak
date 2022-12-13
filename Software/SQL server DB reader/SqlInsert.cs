using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_server_DB_reader
{
    public partial class SqlInsert : Form
    {
        string[] ConString = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public SqlInsert()
        {
            InitializeComponent();

            ServerTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Server.txt"), false);
            DatabaseTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Database.txt"), false);
            UsernameTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Username.txt"), false);
            PasswordTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Password.txt"), false);

            if (File.ReadAllText(@"DataFiles/login/SaveLogin.txt") == "y")
            {
                SaveLoginCheckBox.Checked = true;
            }

            UpdateConString();

            TableComboBoxUpdate();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TableComboBoxUpdate();
        }

        private void RunCommandButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = SqlCommandRichTextBox.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            TableComboBoxUpdate();
        }

        private void ViewFullTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ViewFullTableComboBox.Text != "") | (ViewFullTableComboBox.Text != null))
            {
                UpdateDatabaseView();
            }
        }

        string ConStringFull()
        {
            UpdateConString();

            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }
            return ConStringFull;
        }

        string CaesarCipher(string input, bool encrypt)
        {
            string order = "wGho+[iYyZ>?JDU8}<fI&Frqx6Ov,A9a5lnp]2bjM|:z7QC.~`mgK4@^ENu()_WXTt-eV#$%H0/{ck1PL=SB!dRs3*'";  // exlcuding ; / and "  default caesar ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-=_+[]',./{}|:<>?~`
            string output = "";
            if (encrypt)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    bool fail = true;
                    for (int j = 0; j < order.Length; j++)
                    {
                        if (input[i] == order[j])
                        {
                            if (j < order.Length - 1)
                            {
                                output = output + order[j + 1];
                                fail = false;
                            }
                            else if (j == order.Length - 1)
                            {
                                output = output + order[0];
                                fail = false;
                            }
                        }
                    }
                    if (fail)
                    {
                        output = output + input[i];
                    }
                }
            }
            else if (!encrypt)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    bool fail = true;
                    for (int j = 0; j < order.Length; j++)
                    {
                        if (input[i] == order[j])
                        {
                            if (j > 0)
                            {
                                output = output + order[j - 1];
                                fail = false;
                            }
                            else if (j == 0)
                            {
                                output = output + order[order.Length - 1];
                                fail = false;
                            }
                        }
                    }
                    if (fail)
                    {
                        output = output + input[i];
                    }
                }
            }
            return output;
        }

        void UpdateConString()
        {
            string SecuInfo = "";
            if (SaveLoginCheckBox.Checked)
            {
                SecuInfo = "True";
            }
            else
            {
                SecuInfo = "False";
            }

            ConString[0] = "Data Source=";
            ConString[1] = ServerTextBox.Text;
            ConString[2] = ";Initial Catalog=";
            ConString[3] = DatabaseTextBox.Text;
            ConString[4] = ";Persist Security Info=";
            ConString[5] = SecuInfo;
            ConString[6] = ";User ID=";
            ConString[7] = UsernameTextBox.Text;
            ConString[8] = ";Password=";
            ConString[9] = PasswordTextBox.Text;
        }

        void TableComboBoxUpdate()
        {
            ViewFullTableComboBox.Items.Clear();

            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = "SELECT * FROM SYSOBJECTS WHERE xtype = 'U'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ViewFullTableComboBox.Items.Add(reader["name"]);
            }
            conn.Close();
        }

        void UpdateDatabaseView()
        {
            var Colloms = new List<string>();

            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + ViewFullTableComboBox.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Colloms.Add((string)reader["name"]);
            }
            conn.Close();

            ViewFullTableDataGridView.ColumnCount = Colloms.Count;
            for (int i = 0; i < Colloms.Count; i++)
            {
                ViewFullTableDataGridView.Columns[i].DisplayIndex = i;
                ViewFullTableDataGridView.Columns[i].Name = Colloms[i];
            }


            conn.Open();
            query = "Select * from " + ViewFullTableComboBox.Text;
            SqlCommand cmd1 = new SqlCommand(query, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string[] row = new string[Colloms.Count];
                int i;
                for (i = 0; i < Colloms.Count; i++)
                {
                    string chace = reader[Colloms[i]].ToString();
                    row[i] = chace;
                }

                string[] RowFull = new string[Colloms.Count];
                i = 0;
                foreach (string item in row)
                {
                    RowFull[i] = item;
                    i++;
                }
                ViewFullTableDataGridView.Rows.Add(RowFull);
            }
            conn.Close();
        }

        
    }
}
