using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Application = System.Windows.Forms.Application;

namespace PhpMyAdmin_read_and_visualize
{
    public partial class NotSavedNotification : Form
    {
        public NotSavedNotification()
        {
            InitializeComponent();

        }

        //void SaveAnyways()
        //{
        //    string[] ConString = { "", "", "", "", "", "", "", "", "", "", };
        //    using (Form1 form1 = new Form1())
        //    {
        //        ConString = form1.ConStringFetcher;
        //    }

        //    string ConStringFull = "";
        //    for (int i = 0; i < ConString.Length; i++)
        //    {
        //        ConStringFull = ConStringFull + ConString[i];
        //    }
        //    using (Form1 form1 = new Form1())
        //    {
        //        File.WriteAllText(@"DataFiles/Login/Server.txt", form1.CaesarCipher(ConString[1], true));
        //        File.WriteAllText(@"DataFiles/Login/Database.txt", form1.CaesarCipher(ConString[3], true));
        //        File.WriteAllText(@"DataFiles/Login/Username.txt", form1.CaesarCipher(ConString[5], true));
        //        File.WriteAllText(@"DataFiles/Login/Password.txt", form1.CaesarCipher(ConString[4], true));
        //    }
        //}

        //private void SaveAnywaysButton_Click(object sender, EventArgs e)
        //{
        //    SaveAnyways();
        //    Close();
        //}

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
