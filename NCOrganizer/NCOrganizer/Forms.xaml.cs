using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Diagnostics;

namespace NCOrganizer
{
    /// <summary>
    /// Interaction logic for Forms.xaml
    /// </summary>
    
    public partial class Forms : Window
    {
        private Notecard newCard = new Notecard();
        private string path = @"C:\Users\Max Hendricks\Documents\NotecardNotes\";

        public Forms()
        {
            InitializeComponent();
            DateTime newDateTime = DateTime.Now; // Gets the date currently
            this.DateBox.SelectedDate = newDateTime; // Initiates the box to newDateTime
            Create_Button.Click += Check_Mate;
        }

        private void Save_File(object sender, RoutedEventArgs e)
        {
            
            newCard.setTitle(this.Box1.Text);
            newCard.setCategory(this.Box2.Text);
            newCard.setDate(this.DateBox.Text);

            try
            {
                if (File.Exists(path + newCard.getTitle() + ".txt")) // If the path starts, that means there is a path already with that title
                {
                    MessageBox.Show("There's already a file under this name. Please try again.");
                }
                else
                {
                    FileStream newFile = File.Create(path + newCard.getTitle() + ".txt");
                    newFile.Close(); // Closing the file after creating it
                    Process.Start(path + newCard.getTitle() + ".txt");
                    Add_Button(sender, e);
                }
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Error, there was an issue with opening the file. Please try again.");
            }


        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            notepadScreen screen = new notepadScreen();
            screen.Show();
            this.Close();
        }

        private void Check_Mate(object sender, RoutedEventArgs e)
        {
            if(this.Box1.Text == "" || this.Box2.Text == "" || this.DateBox.Text == "")
            {
                MessageBox.Show("Error, please fill out all fields");
            }
            else
            {
                Save_File(sender, e);
            }
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            notepadScreen screen = new notepadScreen();
            screen.Show();
            this.Close();
        }

        private void Direct_Path(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(path + newCard.getTitle() + ".txt");
        }
    }
}
