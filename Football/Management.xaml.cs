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
using System.IO;

namespace Sports
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Window
    {
        public Management()
        {
            InitializeComponent();
        }

        private void CreateFile_Goals(object sender, MouseButtonEventArgs e)
        {
            StreamWriter OurSteam;
            OurSteam = File.CreateText("bbgoals.Goals");
            OurSteam.Write("Coaches Thoughts");
            OurSteam.Close();
        }

        private void Writegoals(object sender, MouseButtonEventArgs e)
        {
            string text = File.ReadAllText("bbgoals.Goals");
            var output = text;
            var plays = new Plays();
            TextBox Options = new TextBox();
            Options.Margin = new Thickness(50, 50, 0, 0);
            Options.Height = 500;
            Options.Width = 1000;
            Options.TextAlignment = TextAlignment.Center;
            Options.Text = output;
            Options.MaxLines = 5;
            Options.Background = Brushes.Gold;
            plays.Content = Options;
            plays.FontSize = 35;
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }
        // Offense
        private void playone(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays() ;
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "Fresno";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playtwo(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "Basic";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playthree(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "Fold-N";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playfour(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playfive(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playsix(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playseven(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }
        // Defense
        private void playeight(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playnine(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playten(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playeleven(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playtwelve(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playthirteen(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void playfourteen(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }
    }
}
