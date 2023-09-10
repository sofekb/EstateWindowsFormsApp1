using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public class School : Institutional
    {
        private List<GradeLevels> gradeLevels;

        public School(int id, Address address, Category category, LegalForm legalForm, string name) 
            : base(id, address, category, legalForm, name)
        {
        }

     
    }
}
