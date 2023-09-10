using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public abstract class Institutional : Estate
    {
        private string name;
        private GovernTypes governType;

        //constructor with only base parameters
        public Institutional (int id, Address address, Category category, LegalForm legalForm, string name)
            : base (id, address, category, legalForm)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public GovernTypes GovernType
        {
            get { return governType;  }
            set { governType = value; }
        }

    }
}
