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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte correctAnswers = 0;
            foreach (RadioButton radioButton in Question1.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Content == "4")
                {
                    correctAnswers++;
                }
            }
            foreach (RadioButton radioButton in Question2.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Content == "3")
                {
                    correctAnswers++;
                }
            }
            foreach (RadioButton radioButton in Question3.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Content == "Линейный")
                {
                    correctAnswers++;
                }
            }
            foreach (RadioButton radioButton in Question4.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Content == "Половина длины гипотенузы")
                {
                    correctAnswers++;
                }
            }
            MessageBox.Show($"Вы ответили верно на {correctAnswers}/4");

        }
    }
}