using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetFichierLectureEcriture
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
            string textName = "ScoresGOT.CSV";
            string path = AppDomain.CurrentDomain.BaseDirectory + textName;
            StreamReader streamReader = new StreamReader(path);
            string splitter = "";
            List <string> lines = new List<string>();


            if(File.Exists(path))
            {
                path = streamReader.ReadLine();


                while(!streamReader.EndOfStream)
                {
                    splitter = streamReader.ReadLine();
                    string[] value = splitter.Split(';');
                    string filteredLine = string.Join(";", value.Skip(value.Length - 2));
                    lines.Add(filteredLine);
                }

                double sommeValue1 = 0;
                double sommeValue2 = 0;
                int valuesNumber = 0;
                for(var i = 0; i< lines.Count; i++) {

                    string line = lines[i];
                    string[] split = line.Split(';');
                    int value1 = int.Parse(split[0]);
                    int value2 = int.Parse(split[1]);

                    if(value1 != 0 && value2 != 0)
                    {
                        sommeValue1 += value1;
                        sommeValue2 += value2;
                        valuesNumber++;
                    }
    
                }

                if(valuesNumber > 0)
                {
                    double moyenneValue1 = sommeValue1 / valuesNumber;
                    double moyenneValue2 = sommeValue2 / valuesNumber;
                    DisplayMoyenne.Text = "La moyenne de success rate" + moyenneValue1 + "\n" + "la moyenne de score est de " + moyenneValue2;
                }
                else
                {
                    MessageBox.Show("Aucune valeur non nulle trouvée pour calculer la moyenne.");
                }


                streamReader.Close();
                
            }

        }
    }
}
