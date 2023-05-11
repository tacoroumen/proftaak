namespace Userinterface_proftaak
{
    internal class LoginInfo
    {
        private string hostname;
        private string password;
        private string client;
        private string username;

        public string MQTTHostname { get; private set; }
        public string MQTTClient { get; private set; }
        public string MQTTUsername { get; private set; }
        public string MQTTPassword { get; private set; }
        public string UserIDPath { get; private set; }

        public LoginInfo()
        {
            hostname = "145.220.75.105";
            client = "test";
            username = "proftaak";
            password = "04juLi2003!";
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