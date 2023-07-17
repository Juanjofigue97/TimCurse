using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonModelLibrary;

namespace DemoPersonInformation
{
    public partial class MainForm : Form
    {
        public static PersonModel person = new PersonModel();
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            addressForm.ShowDialog();
            
        }

        private void saveFormButton_Click(object sender, EventArgs e)
        {
            person.FirstName = firstNameText.Text;
            person.LastName = lastNameText.Text;
            person.CellPhone = cellphoneText.Text;
            person.Age = Convert.ToInt32(ageText.Text);

            MessageBox.Show($" Personal Information: { person.FirstName } , { person.LastName } \n Address:{ person.Address}");
        }
    }
}
