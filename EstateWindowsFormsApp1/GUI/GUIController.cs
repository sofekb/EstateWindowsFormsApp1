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
        private static List<Estate> addedEstatesList = new List<Estate>();

        public GUIController() 
        {
        }

        public void AddEstate(Estate estate)
        {
            addedEstatesList.Add(estate);
        }

        public List<Estate> GetEstatesList() 
        {
            return addedEstatesList;
        }

        public void UpdateAddedEstatesListView(ListView listView, List<Estate> addedEstatesList)
        {
            listView.Items.Clear();

            foreach (Estate estate in addedEstatesList) 
            {
                ListViewItem item = new ListViewItem(estate.EstateAddress.Street);

            }
        }
    }
}
