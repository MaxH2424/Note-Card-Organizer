﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NCOrganizer
{
    /// <summary>
    /// Interaction logic for notepadScreen.xaml
    /// </summary>
    public partial class notepadScreen : Window
    {
        public notepadScreen()
        {
            InitializeComponent();

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            // Shows the next window
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
            this.Close();
        }

        private void Add_Card(object sender, RoutedEventArgs e)
        {
            Forms newForm = new Forms();
            newForm.Show();
        }

    }
}