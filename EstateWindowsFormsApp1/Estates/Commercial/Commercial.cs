//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates.Commercial
{
    //abstract base class to all commercial concrete classes
    public abstract class Commercial : Estate
    {
        public string CompanyName { get; set; }

        public Commercial() { }
    }
}
