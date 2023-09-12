using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Residential
{
    public class Apartment : Residential
    {
        public int Floor { get; set; }

        public Apartment(int id, Address address, string category, string legalForm, 
            int bedrooms, int squareMeter, int floor) 
            : base(id, address, category, legalForm, bedrooms, squareMeter)
        {
            Floor = floor;
        }
    }
}
