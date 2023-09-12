using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Residential
{
    public class Villa : Residential
    {
        public int SquareMeterGarden { get; set; }

        public Villa(int id, Address address, string category, string legalForm, 
            int bedrooms, int squareMeter, int squareMeterGarden) 
            : base(id, address, category, legalForm, bedrooms, squareMeter)
        {
            SquareMeterGarden = squareMeterGarden;
        }
    }
}
