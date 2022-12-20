using Microsoft.Identity.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    //to choose which method, make if statement and call a value from FormUser. The value will be changed on what needs to be done
    //example: when paper, string test is canged to "paper". This value will be called in this class and then be used to determine which method to choose
    internal class Database
    {
        public string Connectionstring { get; private set; }//define values so they can be used across the class
        public SqlConnection Connection { get; private set; }
        public void ConnectionDatabase()
        {
            Connectionstring = @"Data Source=145.220.75.105;Initial Catalog=Recycle Project;User Id=SA;Password=04juLi2003!";
            Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            //close connection every time a query is made. It is not good to use the same connection for multiple query
        }


        //*method separation
        //will be separated in different methods for the different values needed
        //scan card, weight of the different materials and the total weight, the total weight will most likely either be a method that is 
        //called in every material method, or a method on its own
        //works as intended for now
        //*method separation
       

        public void ReadDatabase()//test method
        {
            ConnectionDatabase();//establish connection

            //read from database
            string query = "SELECT * FROM sys.databases";//define the query 
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader reader = cmd.ExecuteReader();//define reader
            while (reader.Read()) //get values from the database
            {
                MessageBox.Show(reader["name"].ToString());
            }
            Connection.Close();
        }

        public void WriteDatabase()//test method
        {
            ConnectionDatabase();//establish connection

            //insert into database
            string query = "INSERT INTO Weights (Weight) VALUES (3)"; //query you want to insert || sring query = *insert*
            SqlCommand cmd = new SqlCommand(query, Connection); //SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public void ValidateCard(string userid)
        {
            ConnectionDatabase();
        }
    }
}
//Only use when needed, connection closes after every query
