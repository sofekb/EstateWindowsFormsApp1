using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EstateWindowsFormsApp1.Estates
{
    public interface IEstate
    {
        int Id { get; set; }

        Address EstateAddress { get; set; }

        Category EstateCategory{ get; set; }

        LegalForm EstateLegalForm { get; set; }

    }
}
