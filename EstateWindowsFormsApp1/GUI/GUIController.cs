//Sofia Ekberg Sept 2023
using EstateWindowsFormsApp1.Estates;

namespace EstateWindowsFormsApp1.GUI
{
    /*current purpose is mainly keeping track of current estate object.
     * will be further developed, perhaps to keep track of the interaction between multiple Forms*/
    public class GUIController
    {
        public Estate CurrentEstate { get; set; } //keeping track of the current estate in the Form

        public GUIController() 
        {
        }

    }
}
