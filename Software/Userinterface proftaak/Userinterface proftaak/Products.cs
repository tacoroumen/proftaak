using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinterface_proftaak
{
    internal class Products
    {
        public string Materials { get; private set; }
        public string Weight { get; private set; }
        public string Price { get; private set; }
        public int Selectedmaterial { get; set; }

        public Products(string materials, string weight, string price)
        {
            price = "fontys/price";
            materials = "fontys/materials";
            weight = "fontys/weight";
            this.Price = price;
            this.Materials = materials;
            this.Weight = weight;
        }
    }
}