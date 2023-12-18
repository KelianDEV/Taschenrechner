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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
      
        private void Buttonkomma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Buttonminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(0);
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(1);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(3);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(4);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(5);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(6);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(8);
        }

        private void Buttton9_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton(9);
        }


        private int currentValue = 0;

        private void HandleNumberButton(int number)
        {
            
            currentValue = currentValue * 10 + number;

            
            Textbox.Text = currentValue.ToString();
        }

        private void Buttonplus_Click(object sender, RoutedEventArgs e)
        {
            HandleNumberButton("+");
        }
    }
}
