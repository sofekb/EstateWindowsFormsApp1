//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    //concrete sub class
    public class Hospital : Institutional
    {
        public int MaxCapacity { get; set; }

        public Hospital() { }

        public override string ToString()
        {
            return "Hospital: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }

    }
}
