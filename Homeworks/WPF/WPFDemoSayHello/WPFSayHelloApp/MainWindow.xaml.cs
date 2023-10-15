﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSayHelloApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstNameText.Text == string.Empty && LastNameText.Text == string.Empty)
            {
                SayHello.Text = "";
                MessageBox.Show("Error, You have to write your FirstName or LastName", "Error Message",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                SayHello.Text = $"Hello: {FirstNameText.Text} {LastNameText.Text}";
            }
            FirstNameText.Text = "";
            LastNameText.Text = "";
        }
    }
}
