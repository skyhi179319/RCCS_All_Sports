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
    /// Interaction logic for GameDay.xaml
    /// </summary>
    public partial class GameDay : Window
    {
        public GameDay()
        {
            InitializeComponent();
        }
        private void playone(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "Fresno";
            plays.Content = text;
            plays.FontSize = 75;
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
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
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }
        // Tip Off
        private void Tipoff(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 500;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "Fresno/None";
            plays.Content = text;
            plays.FontSize = 75;
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }
        // Drills
        private void Drillone(object sender, MouseButtonEventArgs e)
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
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void Drilltwo(object sender, MouseButtonEventArgs e)
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
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void Drillthree(object sender, MouseButtonEventArgs e)
        {
            var plays = new Plays();
            TextBlock text = new TextBlock();
            text.Margin = new Thickness(50, 50, 0, 0);
            text.Height = 200;
            text.Width = 220;
            text.TextAlignment = TextAlignment.Center;
            text.Text = "None";
            plays.Content = text;
            plays.Background = Brushes.AliceBlue;
            plays.FontSize = 75;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void Drillfour(object sender, MouseButtonEventArgs e)
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
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void Drillfive(object sender, MouseButtonEventArgs e)
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
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void Drillsix(object sender, MouseButtonEventArgs e)
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
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }
        private void CreateFile(object sender, MouseButtonEventArgs e)
        {
            StreamWriter Halftime;
            Halftime = File.CreateText("bbHalftime.info");
            Halftime.Write("Coaches Thoughts");
            Halftime.Close();
        }

        private void OpenFile(object sender, MouseButtonEventArgs e)
        {
            string text = File.ReadAllText("bbHalftime.info");
            var output = text;
            var plays = new Plays();
            TextBox Notes = new TextBox();
            Notes.Margin = new Thickness(50, 50, 0, 0);
            Notes.Height = 500;
            Notes.Width = 1000;
            Notes.TextAlignment = TextAlignment.Center;
            Notes.Text = output;
            Notes.MaxLines = 5;
            plays.Content = Notes;
            plays.FontSize = 35;
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void CreateNote(object sender, MouseButtonEventArgs e)
        {
            StreamWriter Note;
            Note = File.CreateText("bbCoaches_Note.info");
            Note.Close();
        }

        private void OpenNote(object sender, MouseButtonEventArgs e)
        {
            string text = File.ReadAllText("bbCoaches_Note.info");
            var output = text;
            var plays = new Plays();
            TextBox Notes = new TextBox();
            Notes.Margin = new Thickness(50, 50, 0, 0);
            Notes.Height = 500;
            Notes.Width = 1000;
            Notes.TextAlignment = TextAlignment.Center;
            Notes.Text = output;
            Notes.MaxLines = 5;
            Notes.Background = Brushes.Gold;
            plays.Content = Notes;
            plays.FontSize = 35;
            plays.Background = Brushes.AliceBlue;
            plays.WindowState = WindowState.Maximized;
            plays.Show();
            WindowState = WindowState.Minimized;
        }

        private void CreateOption(object sender, MouseButtonEventArgs e)
        {
            StreamWriter Option;
            Option = File.CreateText("bbOptions.info");
            Option.Close();
        }

        private void OpenOption(object sender, MouseButtonEventArgs e)
        {
            string text = File.ReadAllText("bbOptions.info");
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
        private void BiggerScoreboard(object sender, RoutedEventArgs e)
        {
            if (File.Exists("bbHome.Score") & File.Exists("bbAway.Score") & File.Exists("bbHome.Foul") & File.Exists("bbAway.Foul"))
            {

            }
            else
            {
                StreamWriter Home_Score;
                StreamWriter Away_Score;
                StreamWriter Home_Foul;
                StreamWriter Away_Foul;
                Home_Score = File.CreateText("bbHome.Score");
                Home_Score.WriteLine("0");
                Home_Score.Close();
                Away_Score = File.CreateText("bbAway.Score");
                Away_Score.WriteLine("0");
                Away_Score.Close();
                Home_Foul = File.CreateText("bbHome.Foul");
                Home_Foul.WriteLine("0");
                Home_Foul.Close();
                Away_Foul = File.CreateText("bbAway.Foul");
                Away_Foul.WriteLine("0");
                Away_Foul.Close();
            }
            var scoreboard = new ScoreBoard();
            scoreboard.Show();
        }
    }
}