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

namespace WpfBSD
{
    public partial class MainWindow : Window
    {
        public int CounterValue { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            CounterValue = 0;
            Number1 = 0;
            Number2 = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            CounterValue++;
            counter.Content = CounterValue.ToString();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            CounterValue--;
            counter.Content = CounterValue.ToString();
        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            if(CheckValidOperation())
            {
                resultLabel.Content = Number1 + Number2;
            }
        }

        private void substractionButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValidOperation())
            {
                resultLabel.Content = Number1 - Number2;
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValidOperation())
            {
                resultLabel.Content = Number1 * Number2;
            }
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckValidOperation())
            {
                resultLabel.Content = Number1 / Number2;
            }
        }

        public bool CheckValidOperation()
        {
            int number1 = 0;
            int number2 = 0;

            bool result = int.TryParse(firstNumberTextBlock.Text, out number1) && int.TryParse(secondNumberTextBlock.Text, out number2);

            Number1 = number1;
            Number2 = number2;

            if(!result)
            {
                resultLabel.Content = "error";
            }

            return result;
        }
    }
}
