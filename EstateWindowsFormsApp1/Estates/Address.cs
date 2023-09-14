//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates
{
    //is a Property in all estate-objects
    public class Address
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }

        public Address() { }
    }
}
