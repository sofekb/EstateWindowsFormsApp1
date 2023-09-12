using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Residential
{
    public class TownHouse : Villa
    {
        public string Association { get; set; }

        public TownHouse(int id, Address address, string category, string legalForm, 
            int bedrooms, int squareMeter, int squareMeterGarden, string association) 
            : base(id, address, category, legalForm, bedrooms, squareMeter, squareMeterGarden)
        {
            Association = association;
        }
    }
}
