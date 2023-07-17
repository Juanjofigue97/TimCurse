using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetUser
{
    public partial class Dashdoard : Form
    {
        public Dashdoard()
        {
            InitializeComponent();
        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            if (ChechIfNotEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid first name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                FirstNameTextBox.Focus();
            }else if(ChechIfNotEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Focus();
            }
            else
            {
                MessageBox.Show($"Hello {FirstNameTextBox.Text} {LastNameTextBox.Text}","Say Hi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
            }

        }

        private bool ChechIfNotEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}
