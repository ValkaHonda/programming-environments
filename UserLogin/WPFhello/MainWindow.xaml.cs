﻿using System;
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

namespace WPFhello
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String userInput = txtName.Text;
            if(userInput.Length < 2)
            {
                MessageBox.Show("Your name must be at least two chararcters long.");
            } else
            {
                MessageBox.Show("Hello, " + txtName.Text + "!!!" + Environment.NewLine
                    + "this is your first program on VS 2017");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String factorial = factorialInput.Text;
            long factorialValue = long.Parse(factorial);
            long factorialResult = calculateFactorial(factorialValue);
            MessageBox.Show("Factorial of " + factorial + " is == " + factorialResult);
        }
        long calculateFactorial(long number)
        {
            long result = 1;
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String baseNumber = factorialInput.Text;
            long baseValue = long.Parse(baseNumber);
            String power = powerInput.Text;
            long powerValue = long.Parse(power);
            double result = Math.Pow(baseValue, powerValue);
            MessageBox.Show(baseValue+"^"+powerValue+" == "+result);
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            //do my stuff before closing
            MessageBoxResult result = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            }
            base.OnClosing(e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();
            foreach (var item in mainGrid.Children)
            {
                if (item is TextBox)
                {
                    messageBuilder.Append(((TextBox)item).Text)
                        .Append(Environment.NewLine);
                }
            }
            messageBuilder.Append("welcome!");
            MessageBox.Show(messageBuilder.ToString());

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, Windows Presenation Foudation!");
            TextBlock1.Text = DateTime.Now.ToString();
        }
    }
}