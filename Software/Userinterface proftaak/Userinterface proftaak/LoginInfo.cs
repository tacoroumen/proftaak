namespace Userinterface_proftaak
{
    internal class LoginInfo
    {
        public string MQTTHostname { get; private set; }
        public string MQTTClient { get; private set; }
        public string MQTTUsername { get; private set; }
        public string MQTTPassword { get; private set; }
        public string UserIDPath { get; private set; }

        public LoginInfo()
        {
            string hostname = "145.220.75.105";
            string client = "test";
            string username = "proftaak";
            string password = "04juLi2003!";
            this.MQTTHostname = hostname;
            this.MQTTClient = client;
            this.MQTTUsername = username;
            this.MQTTPassword = password;
        }
        public LoginInfo(string useridpath)
        {
            useridpath = "fontys/user";
            this.UserIDPath = useridpath;
        }
    }
}