using EstateWindowsFormsApp1.Estates;
using EstateWindowsFormsApp1.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GUIController guiController = new GUIController();
        public Form1()
        {
            InitializeComponent();
            List<Estate> estatesList = guiController.GetEstatesList();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //controls which elements are visible and populating buildingTypeComboBox depending on category
        private void visibleCategoryElements()
        {
            buildingTypeComboBox.Items.Clear();
            buildingTypeComboBox.Text = string.Empty; //empties the comboBox from the previous choice
            emptyBuildingContainers();
            institutionContainer.Visible = false;
            residentialContainer.Visible = false;
            commercialContainer.Visible = false;
            buildingTypeContainer.Visible = true;

            string category = categoryComboBox.Text;
            switch (category)
            {
                case "Institutional":
                    institutionContainer.Visible = true;
                    buildingTypeComboBox.Items.Add("Hospital");
                    buildingTypeComboBox.Items.Add("School");
                    buildingTypeComboBox.Items.Add("University");
                    break;
                case "Residential":
                    residentialContainer.Visible = true;
                    buildingTypeComboBox.Items.Add("Villa");
                    buildingTypeComboBox.Items.Add("Apartment");
                    buildingTypeComboBox.Items.Add("Town house");
                    break;
                case "Commercial":
                    commercialContainer.Visible= true;
                    buildingTypeComboBox.Items.Add("Office");
                    buildingTypeComboBox.Items.Add("Shop");
                    buildingTypeComboBox.Items.Add("Warehouse");
                    break;
            }

        }

        //controls whoch elements are visible depending on building type
        private void visibleBuildingTypeElements()
        {
            emptyBuildingContainers();

            string buildingType = buildingTypeComboBox.Text;
            switch (buildingType)
            {
                case "Hospital":
                    hospitalContainer.Visible = true;
                    break;
                case "School":
                    schoolContainer.Visible = true;
                    break;
                case "University":
                    universityContainer.Visible = true; 
                    break;
                case "Villa":
                    villaContainer.Visible = true;
                    break;
                case "Town house":
                    villaContainer.Visible= true;
                    townHouseContainer.Visible = true;
                    break;
                case "Apartment":
                    apartmentContainer.Visible = true;
                    break;
                case "Office":
                    officeContainer.Visible = true; 
                    break;
                case "Shop":
                    shopContainer.Visible = true;   
                    break;
                case "Warehouse":
                    warehouseContainer.Visible = true;
                    break;
            }
        }

        //occur when the user chooses a category
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            estateContainer.Visible = true;
            buildingTypeComboBox.Items.Clear(); 
            visibleCategoryElements();
        }

        private void buildingTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibleBuildingTypeElements();
        }

        //empties building-specific containers
        private void emptyBuildingContainers()
        {
            hospitalContainer.Visible = false;
            schoolContainer.Visible = false;
            universityContainer.Visible = false;
            villaContainer.Visible = false;
            townHouseContainer.Visible = false;
            apartmentContainer.Visible = false;
            officeContainer.Visible = false;
            shopContainer.Visible = false;
            warehouseContainer.Visible = false;
        }
    }
}
