﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates.Institutional
{
    public class Hospital : Institutional
    {
        public int MaxCapacity { get; set; }

        public Hospital(int id, Address address, Category category, LegalForm legalForm, 
            string name, int maxCapacity) 
            : base(id, address, category, legalForm, name)
        {
            MaxCapacity = maxCapacity;
        }
    }
}