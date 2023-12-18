using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace TP2_JustePrix
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
        public int Result { get; set; }
        public int CurPrice { get; set; }
        public List<Users> Users { get; set; }
        public int Score{ get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            MinPrice = 0;
            MaxPrice= 100;
            Score = 1000;
            CurPrice = random.Next(MinPrice, MaxPrice + 1);
            Users = new List<Users>();

            MessageBox.Show(CurPrice.ToString());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Jeux();
            string jsonString;
            jsonString = JsonSerializer.Serialize(Users);
            string jsonFileName = "Myfile.json";
            string path = AppDomain.CurrentDomain.BaseDirectory + jsonFileName;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(jsonString);
            sw.Close();
        }

        private void Jeux()
        {
            int nbUser =0;

            if (int.TryParse(textUser.Text, out nbUser))
            {
                Result = nbUser;

                if (nbUser == CurPrice)
                {
                    MessageBox.Show("Félicitation ! Tu as trouvé le bon prix");
                    string pseudo = UserPseudo.Text;
                    Users.Add(new Users(pseudo,Math.Abs(Score)));
                    UpdateScores();
                    return;

                }
                else if (nbUser < CurPrice)
                {
                    MessageBox.Show("C'est Plus");
                    Score -= 50;
                    return;
                }
                else
                {
                    MessageBox.Show("C'est moins");
                    Score -= 50;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Le nombre est invalide");

            }
        }

        // Fonction qui permet d'afficher les score dans la ListBox
        private void UpdateScores()
        {
            Users =Users.OrderByDescending(u => u.Score).Take(5).ToList();
            ListScores.ItemsSource = Users.Select(u => $"{u.Pseudo} - Ton Score: {u.Score}").ToList();

        }

        private void ButtonRestart_Click(object sender, RoutedEventArgs e)
        {
            RestartGame();

        }
        private void RestartGame()
        {
            Random random = new Random();
            CurPrice = random.Next(MinPrice, MaxPrice + 1);
            UserPseudo.Text = "";
            textUser.Text = "0";
            MessageBox.Show(CurPrice.ToString());
            Jeux();


        }


    private List<Users> GetBestScores()
        {

         if (Users.Any()){
                int bestScore = Users.Max(u => u.Score);
                List<Users> bestScorers = Users.Where(u => u.Score < bestScore).ToList();
                MessageBox.Show("Le meilleurs score :" + bestScore.ToString());
                return bestScorers;
         }

         return new List<Users>();
        }

        private void ButtonDisplayBestScore_Click(object sender, RoutedEventArgs e)
        {
            GetBestScores();
        }

    private void ReadJson()
        {
            string jsonstring = "";
            string jsonFileName = "MyFile.json";
            string path = AppDomain.CurrentDomain.BaseDirectory + jsonFileName;
            StreamReader sr = new StreamReader(path);
            jsonstring = sr.ReadLine();
            sr.Close();

            try
            {
                User user =
            }

            UpdateScores();
        }

    }

}
