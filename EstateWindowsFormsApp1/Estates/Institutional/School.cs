using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public class School : Institutional
    {
        public string GradeLevel { get; set; }

        public School() { }

        public override string ToString()
        {
            return "School: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
