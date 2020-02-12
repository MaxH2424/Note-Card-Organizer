using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Diagnostics;

namespace NCOrganizer
{
    /// <summary>
    /// Interaction logic for notepadScreen.xaml
    /// </summary>
    public partial class notepadScreen : Window
    {
        private static string path = @"C:\Users\Max Hendricks\Documents\NotecardNotes\";
        string name = "";
        string[] files = Directory.GetFiles(path);
        List<Button> listOfButtons = new List<Button>();

        public notepadScreen()
        {
            InitializeComponent();

            for (int i = 0; i < files.Length; i++)
            {
                listOfButtons.Add(new Button());
            }

            for (int i = 0; i < files.Length; i++)
            {
                Button newButton = new Button();
                name = files[i];
                newButton.Click += Direct_Path;
                newButton.Content = Path.GetFileName(files[i]);
               
                listOfButtons.ElementAt(i).Click += Direct_Path;
                listOfButtons.ElementAt(i).Content = Path.GetFileName(files[i]);
            }

            for (int i = 0; i < listOfButtons.Count; i++)
            {
                if (i < 3)
                {
                    this.StackPack1.Children.Add(listOfButtons.ElementAt(i));
                }
                else if (i >= 3 && i < 6)
                {
                    this.StackPack2.Children.Add(listOfButtons.ElementAt(i));
                }
                else if (i >= 6 && i < 9)
                {
                    this.StackPack3.Children.Add(listOfButtons.ElementAt(i));
                }
                else if (i >= 9 && i < 12)
                {
                    this.StackPack4.Children.Add(listOfButtons.ElementAt(i));
                }
                else
                {
                    MessageBox.Show("You're at your max limit of notecards");
                }

            }
            
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
            this.Close();
        }

        private void Direct_Path(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString(); // Figures out button clicked.

            for (int i = 0; i < listOfButtons.Count; i++)
            {
                if (listOfButtons.ElementAt(i).Content.ToString() == content)
                {
                    Process.Start(files[i]); // starts files at location where i was found.
                }
            }
        }


    }
}
