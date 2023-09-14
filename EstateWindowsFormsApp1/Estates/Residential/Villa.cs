//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates.Residential
{
    //concrete subclass (and also base class to TownHouse)
    public class Villa : Residential
    {
        public int SquareMeterGarden { get; set; }

        public Villa() { }

        public override string ToString()
        {
            return "Villa: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
