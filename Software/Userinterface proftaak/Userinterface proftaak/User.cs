using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinterface_proftaak
{
    internal class User
    {
        public string MQTTHostName { get; private set; }
        public string MQTTClient {  get; private set; }
        public string MQTTUsername { get; private set; }
        public string MQTTPassword { get; private set; }
        public string UserIDCard { get; private set; }

        public User(string hostname, string client, string username, string password)
        {
            hostname = "145.220.75.105";
            client = "test";
            username = "proftaak";
            password = "04juLi2003!";
            this.MQTTHostName = hostname;
            this.MQTTClient = client;
            this.MQTTUsername = username;
            this.MQTTPassword = password;
        }
        public User(string userid)
        {
            userid = "fontys/user";
            this.UserIDCard = userid;
        }
    }
}