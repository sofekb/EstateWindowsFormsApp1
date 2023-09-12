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

        public University(int id, Address address, Category category, LegalForm legalForm, 
            string name, int numberOfStudents) 
            : base(id, address, category, legalForm, name)
        {
            NumberOfStudents = numberOfStudents;
        }
    }
}
