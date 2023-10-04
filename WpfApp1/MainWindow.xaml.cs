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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int result;
        int num1;
        int num2;
        string option;

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn1.Content;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn2.Content;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn3.Content;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn4.Content;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn5.Content;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn6.Content;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn7.Content;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn8.Content;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn9.Content;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Text = numbersScreen.Text + btn0.Content;
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            option = "*";
            num1 = Int32.Parse(numbersScreen.Text);
            numbersScreen.Clear();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            option = "+";
            num1 = Int32.Parse(numbersScreen.Text);
            numbersScreen.Clear();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            option = "-";
            num1 = Int32.Parse(numbersScreen.Text);
            numbersScreen.Clear();
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            option = "/";
            num1 = Int32.Parse(numbersScreen.Text);
            numbersScreen.Clear();
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
           

            switch(option) 
            {
                case "+":
                    num2 = Int32.Parse(numbersScreen.Text);
                    result = num1 + num2;
                    break;
                case "-":
                    num2 = Int32.Parse(numbersScreen.Text);
                    result = num1 - num2;
                    break;
                case "*":
                     num2 = Int32.Parse(numbersScreen.Text);
                    result = num1 * num2;
                    break;
                case "/":
                    num2 = Int32.Parse(numbersScreen.Text);
                    result = num1 / num2;
                    break;
            }
            numbersScreen.Text = result.ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            numbersScreen.Clear();
            option = "";
            num1 = 0;
            num2  = 0;
            result = 0;
        }
    }
}
