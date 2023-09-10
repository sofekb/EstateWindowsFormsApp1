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
            guiController.UpdateAddedEstatesListView(addedEstatesListView, estatesList);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //method for adding an estate
        private void button1_Click(object sender, EventArgs e)
        {
            Estate estate;
            
            string estateType = comboBox1.Text;

            switch (estateType)
            {
                case "Institutional":

                    FormInstitutional formInstitutional = new FormInstitutional();
                    formInstitutional.Show();
                    break;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
