//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates
{
    //base class for all types of estates
    public abstract class Estate : IEstate
    {
        private static int lastId = 0;  //static counter for id
        public int Id { get; set; }
        public Address EstateAddress { get; set; }
        public string Category { get; set; }
        public string LegalForm { get; set; }

        public Estate() 
        {
            Id = ++lastId;
        }

    }
}
