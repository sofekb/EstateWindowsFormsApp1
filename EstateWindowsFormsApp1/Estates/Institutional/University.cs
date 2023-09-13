using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public class University : Institutional
    {
        public int NumberOfStudents;

        public University() { }

        public override string ToString()
        {
            return "University: " + "Id: " + Id.ToString() + " Street: " + EstateAddress.Street;
        }
    }
}
