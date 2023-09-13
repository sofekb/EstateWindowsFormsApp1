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

        public Villa() { }

        public override string ToString()
        {
            return "Villa: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
