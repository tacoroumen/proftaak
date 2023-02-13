using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;

namespace Userinterface_proftaak
{
    internal class DBUser
    {
        MQTT mqttsettings = new MQTT();
        LoginInfo login = new LoginInfo();
        Database database = new Database();
        Products productspath = new Products("", "", "");
        private string status;
        public bool Valid { get; private set; }
        public string Username { get; private set; }
        public string uuid { get; private set; }
        public DBUser()
        {
            mqttsettings.Products(productspath);
            mqttsettings.Login(login);
        }
        public void CardValidation(bool valid)
        {
            this.uuid = mqttsettings.Cardnumber;
            if (uuid != null)
            {
                database.ValidateCard(uuid, valid);
                valid = database.Valid;
                this.Username= database.Username;
                this.Valid = valid;
                if(this.Valid == false)
                {
                    status = "Denied";
                    mqttsettings.StatusChecked(status);
                }
                else
                {
                    this.uuid = uuid;
                }
            }
        }
        public void DatabaseInsert(string uuid, double weight, int selectedmaterials)
        {
            database.WriteDatabase(uuid, weight, selectedmaterials);
        }
    }
}
