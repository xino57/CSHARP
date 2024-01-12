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

namespace To_Do_List
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Database myDatabase;
        public MainWindow()
        {
            InitializeComponent();
            // Instancie la base de données
            Database myDatabase = new Database();

        }

        private void Display_BDD_ToDoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }

        private void Button_New_Click(object sender, RoutedEventArgs e)
        {
            // Permet de récupérer les valeurs dans le champ "title" et "description"
            string title = TextBox_Title.Text;
            string description = TextBox_Description.Text;


            //Créer une nouvelle task avec les valeurs récupérées
            Task newTask = new Task(title, description, Month.January, Day.Monday, TaskTime.Morning);

            // ajouter la nouvelle tâche à la data base de données 
            myDatabase.Tasks.Add(newTask);

            // Afficher les tâches
            string taskDetails = myDatabase.DisplayTask(myDatabase.Tasks);
            MessageBox.Show(taskDetails, "Tâches actuelles");

        }
    }
}
