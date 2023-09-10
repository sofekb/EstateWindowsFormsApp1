using EstateWindowsFormsApp1.Estates;
using EstateWindowsFormsApp1.Estates.Institutional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateWindowsFormsApp1.GUI
{
    public partial class FormInstitutional : Form
    {
        GUIController guiController = new GUIController();
        public FormInstitutional()
        {
            InitializeComponent();

            //Filling the comboBoxes 
            governTypeComboBox.DataSource = Enum.GetValues(typeof(GovernTypes));
            countryComboBox.DataSource = Enum.GetValues(typeof(Countries));
            legalFormComboBox.DataSource = Enum.GetValues(typeof(LegalForm));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            institutionContainer.Visible = true;
            estateContainer.Visible = true; 
            hospitalContainer.Visible = false;


            string buildingType = comboBox1.Text;
            switch (buildingType)
            {
                case "Hospital":
                    hospitalContainer.Visible = true;
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //method for creating an object
        private void button1_Click(object sender, EventArgs e)
        {
            Estate estate;

            Category category = Category.Institutional;

            //estateContainer input
            string idString = idTextBox.Text;
            int id;
            int.TryParse(idString, out id);
            LegalForm legalForm = (LegalForm)legalFormComboBox.SelectedItem;

            //creating an Address-object
            string street = streetTextBox.Text;
            string zipCode = zipCodeTextBox.Text;
            string city = cityTextBox.Text;
            Countries country = (Countries)countryComboBox.SelectedItem;
            Address address = new Address(street, zipCode, city, country);
            
            //institutionContainer input
            string name = institutionNameTextBox.Text;
            GovernTypes governType = (GovernTypes)governTypeComboBox.SelectedItem;

            string objectType = comboBox1.Text;
            switch (objectType) 
            {
                case "School":

                    try
                    {
                        estate = new School(id, address, category, legalForm, name);
                        Console.WriteLine("school created");
                        guiController.AddEstate(estate);
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine(ex.Message);
                    }

                    break;
            }
            backButton.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
