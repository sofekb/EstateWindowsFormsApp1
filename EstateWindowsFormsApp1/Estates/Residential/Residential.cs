//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates.Residential
{
    //abstract base class to all residential concrete classes
    public abstract class Residential : Estate
    {
        public int Bedrooms { get; set; }
        public int SquareMeter { get; set; }

        public Residential() { }

    }
}
