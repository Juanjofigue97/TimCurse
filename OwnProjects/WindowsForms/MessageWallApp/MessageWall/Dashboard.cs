﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            //messages.Add("First message");
            messageListBox.DataSource = messages;
            messageListBox.DisplayMember = nameof(Dashboard.Text);
        }

        private void AddMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the List.","Blank Message Field",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }
            messageText.Focus();
        }
    }
}
