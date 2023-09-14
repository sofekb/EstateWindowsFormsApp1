//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    //concrete sub class
    public class School : Institutional
    {
        public string GradeLevel { get; set; }

        public School() { }

        public override string ToString()
        {
            return "School: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
