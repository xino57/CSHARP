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
using System.Xml;

namespace Pacourir_Fichier_XML
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            XmlDocument xmlNewFichier = new XmlDocument();
            xmlNewFichier.Load("books.xml");

            XmlNodeList bookNodes = xmlNewFichier.SelectNodes("//book");
            foreach (XmlNode bookNode in bookNodes)
            {
                XmlNode titleNode = bookNode.SelectSingleNode("title");
                XmlNode yearNode = bookNode.SelectSingleNode("year");

                string title = titleNode?.InnerText;
                string year = yearNode?.InnerText;

                if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(year))
                {
                    ListBox.Items.Add($"Title: {title}, Year: {year}");
                }


            }
        }
    }
}

