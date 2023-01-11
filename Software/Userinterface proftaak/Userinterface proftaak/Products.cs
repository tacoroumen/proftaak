namespace Userinterface_proftaak
{
    internal class Products
    {

        public string MaterialsPath { get; private set; }
        public string WeightPath { get; private set; }
        public string PricePath { get; private set; }
        public int Selectedmaterial { get; private set; }

        public Products()
        {
        }

        public Products(string materials, string weight, string price)
        {
            price = "fontys/price";
            materials = "fontys/materials";
            weight = "fontys/weight";
            this.PricePath = price;
            this.MaterialsPath = materials;
            this.WeightPath = weight;
        }
        public void SetMaterial(int materialid)
        {
            Selectedmaterial = materialid;
        }
    }
}