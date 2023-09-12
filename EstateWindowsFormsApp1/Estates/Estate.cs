using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates
{
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

        public Estate(int id, Address address, string category, string legalForm)
        {
            Id = id;
            EstateAddress = address;
            Category = category;
            LegalForm = legalForm;
        }

    }
}
