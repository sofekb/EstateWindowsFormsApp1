using EstateWindowsFormsApp1.Estates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateWindowsFormsApp1.GUI
{
    public class GUIController
    {
        public Estate CurrentEstate { get; set; } //keeping track of the current estate in the Form

        public GUIController() 
        {
        }

    }
}
