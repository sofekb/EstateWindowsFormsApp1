using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public class School : Institutional
    {
        public GradeLevels GradeLevel { get; set; }

        public School(int id, Address address, Category category, LegalForm legalForm, 
            string name, GradeLevels gradeLevel) 
            : base(id, address, category, legalForm, name)
        {
            GradeLevel = gradeLevel;
        }

     
    }
}
