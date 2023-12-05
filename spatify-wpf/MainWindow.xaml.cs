using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace spatify_wpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataBase DB { get; set; }

        public class MusicService
        {
            private static List<Music> allMusics;

            public MusicService()
            {
                allMusics = new List<Music>
                {
                    new Music("Uranus", GenreMusic.rap, "PNL"),
                    new Music("Dive by", GenreMusic.electro, "Train"),
                    new Music("safe and sound ", GenreMusic.classique, "Capital cities"),
                    new Music("GoosBumps", GenreMusic.Rock, "Travis Scoot"),
                    new Music ("musique rap 1", GenreMusic.rap, "Nihno"),
                };
            }

            public List<Music> GetMusics()
            {
                return allMusics;
            }

            public static List<Music> GetMusicByGenre(GenreMusic genreMusic)
            {
                // filtre qui permet d'aller chercher toutes les musiques du même genre.
                return allMusics.FindAll(music => music.GenreMusic == genreMusic);
            }
        }

        private MusicService musicService;
        public MainWindow()
        {
            InitializeComponent();

            MusicService musicService = new MusicService();

            ButtonElectro.Click += GenreButton_Click;
            ButtonRap.Click += GenreButton_Click;
            ButtonRock.Click += GenreButton_Click;

        }

        public void DisplayMusicMethod(List<Music> Musics)
        {
            DisplayMusic.Text = "Songs";
            foreach (Music music in Musics)
            {
                DisplayMusic.Text += $"Title: {music.Title} - Music Genre: {music.GenreMusic} - Artist: {music.Artist} \n";
            }
        }

        private void GenreButton_Click(object sender, RoutedEventArgs e)
        {
            // Déclarer le bouton cliquer dans mon application
            Button clickbutton = sender as Button;
            string selectGenre = clickbutton.Content.ToString();
            GenreMusic genreHolder = new GenreMusic();

            switch (selectGenre)
            {
                case "Electro":
                    genreHolder = GenreMusic.electro;
                    break;

                case "Rap":
                    genreHolder = GenreMusic.rap;
                    break;

                case "Rock":
                    genreHolder = GenreMusic.Rock;
                    break;

                default:
                    Console.WriteLine("erreur");
                    break;
            }
            List <Music> genreMusic = MusicService.GetMusicByGenre(genreHolder);

            DisplayMusicMethod(genreMusic);

        }

        
    }
}
