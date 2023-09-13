using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public abstract class Institutional : Estate
    {
        public string Name { get; set; }
        public string GovernType { get; set; }

        public Institutional() { }

    }
}
