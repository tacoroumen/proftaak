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
using System.IO;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Application = System.Windows.Forms.Application;

namespace SQL_server_DB_reader
{
    public partial class Form1 : Form
    {
        public Form1()
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

        }

        public string CaesarCipher(string input, bool encrypt)
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

        string[] ConString = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; 
        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            string server = ServerTextBox.Text;
            string database = DatabaseTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string SecuInfo = "";
            if (SaveLoginCheckBox.Checked)
            {
                SecuInfo = "True";
            }
            else
            {
                SecuInfo = "False";
            }
            //Data Source=:memory:;Initial Catalog=maindb;Persist Security Info=True;User ID=SA;Password=***********
            ConString[0] = "Data Source=";
            ConString[1] = server;
            ConString[2] = ";Initial Catalog=";
            ConString[3] = database;
            ConString[4] = ";Persist Security Info=";
            ConString[5] = SecuInfo;
            ConString[6] = ";User ID=";
            ConString[7] = username;
            ConString[8] = ";Password=";
            ConString[9] = password;
            //ConString[10] = ";";

            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }
            SqlConnection conn = new SqlConnection(ConStringFull);
            bool login = true;
            try
            {
                conn.Open();
                conn.Close();
                MessageBox.Show("Connected WOOOWOOO!!!!!");
                Form2 form2 = new Form2(ConString);
            }
            catch (Exception expetion)
            {
                Console.WriteLine(expetion.Message);
                login = false;
                MessageBox.Show("Couldn't verify login, Not saving ");
            }
            finally
            {
                conn.Close();
            }

            if (SaveLoginCheckBox.Checked)
            {
                if (login)
                {
                    File.WriteAllText(@"DataFiles/Login/Server.txt", CaesarCipher(server, true));
                    File.WriteAllText(@"DataFiles/Login/Database.txt", CaesarCipher(database, true));
                    File.WriteAllText(@"DataFiles/Login/Username.txt", CaesarCipher(username, true));
                    File.WriteAllText(@"DataFiles/Login/Password.txt", CaesarCipher(password, true));
                }

                File.WriteAllText(@"DataFiles/Login/SaveLogin.txt", "y");
            }
            else if (!SaveLoginCheckBox.Checked)
            {
                File.WriteAllText(@"DataFiles/Login/SaveLogin.txt", "n");
            }
        }

        private void ForgetLoginButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"DataFiles/Login/Server.txt", "");
            File.WriteAllText(@"DataFiles/Login/Database.txt", "");
            File.WriteAllText(@"DataFiles/Login/Username.txt", "");
            File.WriteAllText(@"DataFiles/Login/Password.txt", "");

            File.WriteAllText(@"DataFiles/Login/SaveLogin.txt", "n");

            ServerTextBox.Text = "";
            DatabaseTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";

            SaveLoginCheckBox.Checked = false;
        }
    }
}
