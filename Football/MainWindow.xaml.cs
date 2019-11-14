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

namespace Sports
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

        private void Football(object sender, RoutedEventArgs e)
        {
            new Football_Main_Window().Show();
        }

        private void Basketball(object sender, RoutedEventArgs e)
        {
            new Basketball_Main_Window().Show();
        }

        private void Management(object sender, RoutedEventArgs e)
        {
            new Management().Show();
        }

        private void Message(object sender, MouseButtonEventArgs e)
        {
            var first_basketball_game_date = "December 14";
            var first_basketball_game ="First Basketball Game Is On " + first_basketball_game_date + ".";
            System.Windows.MessageBox.Show(first_basketball_game);
        }

        private void System_Pro(object sender, RoutedEventArgs e)
        {
            new SysPro().Show();
        }

        private void GameDay(object sender, RoutedEventArgs e)
        {
            new GameDay().Show();
        }
    }
}