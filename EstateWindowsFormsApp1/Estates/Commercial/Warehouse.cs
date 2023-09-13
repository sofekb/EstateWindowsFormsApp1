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

        public Warehouse() { }

        public override string ToString()
        {
            return "Warehouse: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
