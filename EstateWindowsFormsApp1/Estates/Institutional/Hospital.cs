using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public class Hospital : Institutional
    {
        public int MaxCapacity { get; set; }

        public Hospital() { }

        public override string ToString()
        {
            return "Hospital: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }

    }
}
