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

namespace NCOrganizer
{
    /// <summary>
    /// Interaction logic for Forms.xaml
    /// </summary>
    
    public partial class Forms : Window
    {
        Notecard newCard = new Notecard();
        string path = @"C:\Users\Max Hendricks\Documents\NotecardNotes\";

        public Forms()
        {
            InitializeComponent();
            Create_Button.Click += Save_File;
            Create_Button.Click += Add_Button;
        }

        private void Save_File(object sender, RoutedEventArgs e)
        {
            
            newCard.setTitle(this.Box1.Text);
            newCard.setCategory(this.Box2.Text);
            newCard.setDate(this.Box3.Text);

            FileStream newFile = File.Create(path + newCard.getTitle() + ".txt");
            newFile.Close(); // Closing the file after creating it

            System.Diagnostics.Process.Start(path + newCard.getTitle() + ".txt");
        }

        private void Add_Button(object sender, RoutedEventArgs e)
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
