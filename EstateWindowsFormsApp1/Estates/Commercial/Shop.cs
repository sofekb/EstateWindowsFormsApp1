using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    public class Shop : Commercial
    {
        public string RetailGenre { get; set; }

        public Shop(int id, Address address, Category category, LegalForm legalForm, 
            string companyName, string retailGenre) 
            : base(id, address, category, legalForm, companyName)
        {
            RetailGenre = retailGenre;
        }
    }
}
