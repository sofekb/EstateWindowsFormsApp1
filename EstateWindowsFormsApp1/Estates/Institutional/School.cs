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

        public School(int id, Address address, string category, string legalForm, 
            string name, string gradeLevel) 
            : base(id, address, category, legalForm, name)
        {
            GradeLevel = gradeLevel;
        }

     
    }
}
