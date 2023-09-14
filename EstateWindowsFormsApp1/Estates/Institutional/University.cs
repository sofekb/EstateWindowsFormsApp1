//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    //concrete sub class
    public class University : Institutional
    {
        public int NumberOfStudents;

        public University() { }

        public override string ToString()
        {
            return "University: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
