using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace To_Do_List
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Database myDatabase { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            // Instancie la base de données
            this.myDatabase = new Database();

            //affecte la liste de tâche à la source de donnée du dataGrid
            Display_BDD_ToDoList.ItemsSource = myDatabase.Tasks;
            AddDayToCombox();
            AddMonthToCombox();
        }

        private void Display_BDD_ToDoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }

        private void Button_New_Click(object sender, RoutedEventArgs e)
        {
            // Permet de récupérer les valeurs dans le champ "title" et "description"
            string title = TextBox_Title.Text;
            string description = TextBox_Description.Text;
            string DatePicker = datePicker.Text;
            string month = ComboBox_Month.Text;
            string day = ComboBox_Day.Text;

            string tasktime = "";
            if (Button_Morning.IsChecked == true)
                tasktime = "Morning";
            else if (Button_Evening.IsChecked == true)
                tasktime = "Evening";
            else if (Button_Noon.IsChecked == true)
                tasktime = "Noon";


            //Créer une nouvelle task avec les valeurs récupérées
            Task newTask = new Task(title, description, DatePicker, day, month, tasktime );

            // ajouter la nouvelle tâche à la data base de données 
            myDatabase.Tasks.Add(newTask);

            // Afficher les tâches
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            // Met à jour la source de données dans la dataGrid
            Display_BDD_ToDoList.ItemsSource = null;
            Display_BDD_ToDoList.ItemsSource = myDatabase.Tasks;
        }

        public void AddMonthToCombox()
        {
            string [] monthName = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            foreach (string month in monthName)
            {
                ComboBox_Month.Items.Add(month);
            }
        }

        public void AddDayToCombox()
        {
            string[] dayName = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            
            foreach(string day in dayName)
            {
                ComboBox_Day.Items.Add(day);
            }

        }
    }
}
