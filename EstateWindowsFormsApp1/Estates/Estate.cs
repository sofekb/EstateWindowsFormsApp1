using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates
{
    public abstract class Estate : IEstate
    {
        public int Id { get; set; }
        public Address EstateAddress { get; set; }
        public Category EstateCategory { get; set; }
        public LegalForm EstateLegalForm { get; set; }

        public Estate(int id, Address address, Category category, LegalForm legalForm)
        {
            Id = id;
            EstateAddress = address;
            EstateCategory = category;
            EstateLegalForm = legalForm;
        }

    }
}
