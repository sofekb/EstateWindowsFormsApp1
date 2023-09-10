using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates
{
    public abstract class Estate : IEstate
    {
        private int id;
        private Address address;
        private Category category;
        private LegalForm legalForm;

        public Estate (int id, Address address, Category category, LegalForm legalForm)
        {
            this.id = id;
            this.address = address;
            this.category = category;
            this.legalForm = legalForm;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Address EstateAddress
        {
            get { return address; }
            set { address = value; }
        }

        public Category EstateCategory
        {
            get { return category; }
            set { category = value; }
        }

        public LegalForm EstateLegalForm
        {
            get { return legalForm; }
            set { legalForm = value; }
        }


    }
}
