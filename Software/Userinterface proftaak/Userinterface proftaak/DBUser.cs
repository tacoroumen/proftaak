using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    internal class DBUser
    {
        MQTT mqttsettings = new MQTT();
        LoginInfo login = new LoginInfo();
        Database database = new Database();
        Products products = new Products();
        Products productspath = new Products("", "", "");
        private string uuid;
        private double weight;
        private int selectedmaterials;

        public DBUser()
        {
            mqttsettings.Products(productspath);
            mqttsettings.Login(login);
            this.weight = mqttsettings.Weightvalue;
            this.selectedmaterials = products.Selectedmaterial;
        }
        public void CardValidation()
        {
            this.uuid = mqttsettings.Cardnumber;

            if (uuid != null)
            {
                database.ValidateCard(uuid);
            }
        }
        public void DatabaseInsert()
        {
            database.WriteDatabase(uuid, weight, selectedmaterials);
        }
    }
}
