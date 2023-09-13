using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    public class Shop : Commercial
    {
        public string RetailGenre { get; set; }

        public Shop() { }

        public override string ToString()
        {
            return "Shop: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
