using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates
{
    public class Address
    {
        private string street;
        private string zipCode;
        private string city;
        private Countries country;

        public Address(string street, string zipCode, string city, Countries country)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
