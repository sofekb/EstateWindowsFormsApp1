using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    public abstract class Commercial : Estate
    {
        public string CompanyName { get; set; }

        public Commercial(int id, Address address, Category category, LegalForm legalForm, string companyName) 
            : base(id, address, category, legalForm)
        {
            CompanyName = companyName;
        }
    }
}
