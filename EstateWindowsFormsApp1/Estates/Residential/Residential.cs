using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Residential
{
    public abstract class Residential : Estate
    {
        public int Bedrooms { get; set; }
        public int SquareMeter { get; set; }

        public Residential(int id, Address address, string category, string legalForm,
            int bedrooms, int squareMeter) 
            : base(id, address, category, legalForm)
        {
            Bedrooms = bedrooms;
            SquareMeter = squareMeter;
        }
    }
}
