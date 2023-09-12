using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Commercial
{
    public class Office : Commercial
    {
        public int Rooms { get; set; }

        public Office(int id, Address address, Category category, LegalForm legalForm, 
            string companyName, int rooms) 
            : base(id, address, category, legalForm, companyName)
        {
            Rooms = rooms;
        }
    }
}
