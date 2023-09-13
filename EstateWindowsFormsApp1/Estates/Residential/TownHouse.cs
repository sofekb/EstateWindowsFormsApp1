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

        public TownHouse() { }

        public override string ToString()
        {
            return "Town house: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
