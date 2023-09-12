using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    public class Warehouse : Commercial
    {
        public int SquareMeters { get; set; }

        public Warehouse(int id, Address address, Category category, LegalForm legalForm, 
            string companyName, int squareMeters) 
            : base(id, address, category, legalForm, companyName)
        {
            SquareMeters = squareMeters;
        }
    }
}
