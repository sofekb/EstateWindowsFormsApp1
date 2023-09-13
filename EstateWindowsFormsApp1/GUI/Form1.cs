﻿using EstateWindowsFormsApp1.Estates;
using EstateWindowsFormsApp1.Estates.Commercial;
using EstateWindowsFormsApp1.Estates.Institutional;
using EstateWindowsFormsApp1.Estates.Residential;
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
            addEstateButton.Visible = true;
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
            shopContainer.Visible = false;
            warehouseContainer.Visible = false;
        }

        //when user clicks on "Add estate"
        private void addEstateButton_Click(object sender, EventArgs e)
        {
            Estate estate;

            string category = categoryComboBox.Text;
            string buildingType = buildingTypeComboBox.Text;
            switch (buildingType)
            {
                case "Hospital":
                    estate = new Hospital();
                    break;
                case "School":
                    estate = new School();
                    break;
                case "University":
                    estate = new University();
                    break;
                case "Villa":
                    estate = new Villa();
                    break;
                case "Town house":
                    estate = new TownHouse();
                    break;
                case "Apartment":
                    estate = new Apartment();
                    break;
                case "Shop":
                    estate = new Shop();
                    break;
                case "Warehouse":
                    estate = new Warehouse();
                    break;
                default:
                    return;                               //vad gör return här?
            }
            guiController.CurrentEstate = estate;
            SetEstateProperties(estate, category);
            SetCategoryProperties(estate);

            idLabel.Text = estate.Id.ToString(); //prints the id onto the Form
            addedEstatesLabel.Text = estate.ToString();

            addEstateButton.Visible = false;
            editEstateButton.Visible = true;
            clearButton.Visible = true;
        }

        //setting the estate properties from the estate container
        private void SetEstateProperties(Estate estate, string category)
        {
            estate.Category = category;
            estate.LegalForm = legalFormComboBox.Text;

            //creating an Address-object and adding it to the estate
            Address address = new Address();
            address.Street = streetTextBox.Text;
            address.ZipCode = zipCodeTextBox.Text;
            address.City = cityTextBox.Text;
            address.Country = (Countries)countryComboBox.SelectedItem;
            estate.EstateAddress = address;
        }

        //calling the correct category properties setting method depending on category
        private void SetCategoryProperties(Estate estate)
        {
            if (estate is Institutional)
            {
                SetInstitutionalProperties((Institutional)estate);
            }
            else if (estate is Residential)
            {
                SetResidentialProperties((Residential)estate);
            }
            else if(estate is Commercial)
            {
                SetCommercialProperties((Commercial)estate);
            }
        }


        //setting the properties for an Institutional object form the institutionContainer
        private void SetInstitutionalProperties(Institutional estate)
        {
            estate.Name = institutionNameTextBox.Text;
            estate.GovernType = governTypeComboBox.Text;
        }

        //setting the properties for a Residential object from the residentialContainer
        private void SetResidentialProperties(Residential estate)
        {
            estate.Bedrooms = (int)noOfBedroomsControl.Value;
            string squareMeterString = squareMeterBedroomTextBox.Text;
            int squareMeter;
            int.TryParse(squareMeterString, out squareMeter); //kolla så det är rätt format
            estate.SquareMeter = squareMeter;
        }

        //setting the properties for a Commercial object from the commercialContainer
        private void SetCommercialProperties(Commercial estate)
        {
            estate.CompanyName = companyNameTextBox.Text;
        }

        //setting the specific sub class properties
        private void SetSubClassProperties(Estate estate)
        {
            switch (estate)
            {
                case Hospital hospital:
                    int maxCapacity;
                    string maxCapacityString = maxCapacityTextBox.Text;
                    int.TryParse(maxCapacityString, out maxCapacity);
                    hospital.MaxCapacity = maxCapacity;
                    break;
                case School school:
                    school.GradeLevel = gradeLevelComboBox.Text;
                    break;
                case University university:
                    int noOfStudents;
                    string noOfStudentsString = noOfstudentsTextBox.Text;
                    int.TryParse(noOfStudentsString, out noOfStudents);
                    university.NumberOfStudents = noOfStudents;
                    break;
                case Villa villa:
                    int gardenSquareMeter;
                    string gardenSquareMeterString = gardenTextBox.Text;
                    int.TryParse(gardenSquareMeterString, out gardenSquareMeter);
                    villa.SquareMeter = gardenSquareMeter;
                    if (villa is TownHouse)
                    {
                        TownHouse townHouse = (TownHouse)villa; //Type-casting to a TownHouse object
                        townHouse.Association = associationTextBox.Text;
                    }
                    break;
                case Apartment apartment:
                    apartment.Floor = (int)floorControl.Value;
                    break;
                case Shop shop:
                    shop.RetailGenre = retailGenreTextBox.Text;
                    break;
                case Warehouse warehouse:
                    int squareMeters;
                    string squareMetersString = squareMetersTextBox.Text;
                    int.TryParse(squareMetersString, out squareMeters);
                    warehouse.SquareMeters = squareMeters;
                    break;
                default:
                                                        //exception ??
                    break;
                }
            }

        //getting information from category container
        private void getCategoryInformation(string category)
        {
            switch (category)
            {
                case "Institutional":
                    string institutionName = institutionNameTextBox.Text;
                    string governType = governTypeComboBox.Text; //behandla annourlunda pga Enum?
                    break;
                case "Residential":
                    decimal numberOfBedrooms = noOfBedroomsControl.Value;
                    string squareMeterString = squareMeterBedroomTextBox.Text;
                    int squareMeter;
                    int.TryParse(squareMeterString, out squareMeter); //omvandlar till int - inputFormat-kontroll?
                    break;
                case "Commercial":
                    string companyName = companyNameTextBox.Text;
                    break;
            }
        }


        //clears the Form from input
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            guiController.CurrentEstate = null;
            this.InitializeComponent();
        }

        //updates the current estates to changed values
        private void editEstateButton_Click(object sender, EventArgs e)
        {
            Estate estate = guiController.CurrentEstate;
            SetEstateProperties(estate, estate.Category);
            SetCategoryProperties(estate);
            SetSubClassProperties(estate);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
