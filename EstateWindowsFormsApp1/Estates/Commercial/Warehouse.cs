//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    //concrete sub class
    public class Warehouse : Commercial
    {
        public int SquareMeters { get; set; }

        public Warehouse() { }

        public override string ToString()
        {
            return "Warehouse: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
