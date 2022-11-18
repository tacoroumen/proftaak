using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Application = System.Windows.Forms.Application;

namespace PhpMyAdmin_read_and_visualize
{
    public partial class Login : Form
    {
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

        public Login()
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

        string[] ConString = { "", "", "", "", "", "", "", "", "", "", };
        public string[] ConStringFetcher
        {
            get { return ConString; }
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            string server = ServerTextBox.Text;
            string database = DatabaseTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            ConString[0] = "SERVER=";
            ConString[1] = server + ";PORT=3306" ;
            ConString[2] = ";DATABASE=";
            ConString[3] = database;
            ConString[4] = ";UID=";
            ConString[5] = username;
            ConString[6] = ";PASSWORD=";
            ConString[7] = password;
            ConString[8] = ";";

            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }
            MySqlConnection conn = new MySqlConnection("SERVER=192.168.160.210;PORT=3306;DATABASE=maindb;UID=proftaak;PASSWORD=04juLi2003!;");
            bool login = true;
            try
            {
                
                conn.Open();
                DataVisualizer form2 = new DataVisualizer();
                form2.Show();

                string query = "Select * from maintable";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["price_reward"]);
                }
            }
            catch (Exception expetion)
            {
                Console.WriteLine(expetion.Message);
                login = false;

                NotSavedNotification form3 = new NotSavedNotification();
                form3.Show();
            } finally
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