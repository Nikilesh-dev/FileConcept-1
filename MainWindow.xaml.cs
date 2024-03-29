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

namespace file_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page page = new Page();
            Frame.Content = page;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page page = new Page();
            Frame.Content = page;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Frame.CanGoForward){
                Frame.GoForward();
            }
            else
            {
                MessageBox.Show("Can't Go Forward");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack) { 
                Frame.GoBack();
            }
            else
            {
                MessageBox.Show("Can't Go Back");
            }
        }
    }
}
