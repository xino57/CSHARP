using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading;
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

namespace MNSWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Player1 = new Player(100);
            Player2 = new Player(100);
        }

        private void player1Attack_Click(object sender, RoutedEventArgs e)
        {
            Player2.HP -= 10;
        }

        private void player2Attack_Click(object sender, RoutedEventArgs e)
        {
            Player1.HP -= 10;
        }
    }
}

