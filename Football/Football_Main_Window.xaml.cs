using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sports
{
    /// <summary>
    /// Interaction logic for Football_Main_Window.xaml
    /// </summary>
    public partial class Football_Main_Window : Window
    {
        public Football_Main_Window()
        {
            InitializeComponent();
        }

        private void Help_Button(object sender, RoutedEventArgs e)
        {
            new Football_Help().Show();
        }

        private void Live_Button(object sender, RoutedEventArgs e)
        {
            new Football_Live().Show();
        }

        private void players(object sender, RoutedEventArgs e)
        {
            new Players().Show();
        }
    }
}
