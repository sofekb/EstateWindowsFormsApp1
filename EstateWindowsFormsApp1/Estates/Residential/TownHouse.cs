//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates.Residential
{
    //concrete subclass
    public class TownHouse : Villa
    {
        public string Association { get; set; }

        public TownHouse() { }

        public override string ToString()
        {
            return "Town house: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
