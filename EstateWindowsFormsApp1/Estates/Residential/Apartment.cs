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

        public Apartment() { }

        public override string ToString()
        {
            return "Apartment: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
