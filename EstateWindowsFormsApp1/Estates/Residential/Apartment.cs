//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Residential
{
    //concrete sub class
    public class Apartment : Residential
    {
        public int Floor { get; set; }

        public Apartment() { }

        public override string ToString()
        {
            return "Apartment: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
