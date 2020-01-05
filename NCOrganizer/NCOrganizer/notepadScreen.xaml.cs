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
        static string path = @"C:\Users\Max Hendricks\Documents\NotecardNotes\";
        string name = "";
        string[] files = Directory.GetFiles(path);
        int i = 0;

        public notepadScreen()
        {
            InitializeComponent();
            
            int buttonCount = 0;
            foreach (string file in files)
            {
                Button newButtons = new Button();
                name = files[buttonCount];
                string filename = buttonCount.ToString();
                newButtons.Click += Direct_Path;
                newButtons.Content = Path.GetFileName(file);
                if (buttonCount < 3)
                {
                    this.StackPack1.Children.Add(newButtons);
                }
                else if (buttonCount >= 3 && buttonCount < 6)
                {
                    this.StackPack2.Children.Add(newButtons);
                }
                else if (buttonCount >= 6 && buttonCount < 9)
                {
                    this.StackPack3.Children.Add(newButtons);
                }
                else if (buttonCount >= 9 && buttonCount < 12)
                {
                    this.StackPack4.Children.Add(newButtons);
                }
                else
                {
                    MessageBox.Show("You're at your max limit of notecards");
                }
                buttonCount++;
            }

            
            foreach (var button in StackPack1.Children.OfType<Button>())
            {
                button.Click += Button_Click;
                i++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(files[i]);
            string filePath = files[i];
            
            System.Diagnostics.Process.Start(filePath);
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
            System.Diagnostics.Process.Start(name);
        }

    }
}
