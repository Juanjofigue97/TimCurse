using PersonModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPersonInformation
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.HomeAddress = homeAddressText.Text;
            address.WorkAddress = workAddressText.Text;
            address.SecondHouseAddress = secondAddressText.Text;

            MainForm.person.Address = address;

            MessageBox.Show($"Your Addresses were saved successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);


            this.Hide();
        }
    }
}
