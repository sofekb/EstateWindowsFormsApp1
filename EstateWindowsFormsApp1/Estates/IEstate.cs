//Sofia Ekberg Sept 2023
namespace EstateWindowsFormsApp1.Estates
{
    //stating the properties that must be implemented for each estate
    public interface IEstate
    {
        int Id { get; set; }

        Address EstateAddress { get; set; }

        string Category{ get; set; }

        string LegalForm { get; set; }

    }
}
