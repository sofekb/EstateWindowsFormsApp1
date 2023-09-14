//Sofia Ekberg Sept 2023

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    //abstract base class to all institutional concrete classes
    public abstract class Institutional : Estate
    {
        public string Name { get; set; }
        public string GovernType { get; set; }

        public Institutional() { }

    }
}
