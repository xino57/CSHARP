using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Formulaire_WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataBase DB { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DB = new DataBase();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BottonSubmit_Click(object sender, RoutedEventArgs e)
        {
            //lastName, string firstName, Month month, bool newsLetters

            string lastName = LastNameBox.Text;
            string firstName = FirstNameBox.Text;

            if(lastName == "" || firstName == "")
            {
                MessageBox.Show("Un champ est manquant");
            }
            else
            {
                Month month = Month.OneMonth;
                if (OneMonth.IsChecked == true)
                {
                    month = Month.OneMonth;
                }
                else if (SixMonth.IsChecked == true)
                {
                    month = Month.SixMonth;

                }
                else if (Year.IsChecked == true)
                {
                    month = Month.Year;
                }

                bool newLetters = false;
                if (CheckBoxNewsLetters.IsChecked == true)
                {
                    newLetters = true;
                }

                User user = new User(lastName, firstName, month, newLetters);
                DB.ListBD.Add(user);

            }

        }
    }
}
