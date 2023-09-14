//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    //concrete sub class
    public class Shop : Commercial
    {
        public string RetailGenre { get; set; }

        public Shop() { }

        public override string ToString()
        {
            return "Shop: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
