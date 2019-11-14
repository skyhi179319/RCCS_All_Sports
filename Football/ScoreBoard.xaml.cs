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
    /// Interaction logic for ScoreBoard.xaml
    /// </summary>
    public partial class ScoreBoard : Window
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void AutoStartScore(object sender, EventArgs e)
        {
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            string Home1 = File.ReadAllText("bbHome.Foul");
            string Away1 = File.ReadAllText("bbAway.Foul");
            int HomeFoul = Int32.Parse(Home1);
            int AwayFoul = Int32.Parse(Away1);
            if (HomeFoul > AwayFoul)
            {
                this.AwayFouls.Background = Brushes.LightGreen;
                this.HomeFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (AwayFoul > HomeFoul)
            {
                this.HomeFouls.Background = Brushes.LightGreen;
                this.AwayFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (HomeFoul == AwayFoul)
            {
                this.AwayFouls.Background = Brushes.Yellow;
                this.HomeFouls.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
        }

        private void CreateFile(object sender, RoutedEventArgs e)
        {
            StreamWriter Home;
            StreamWriter Away;
            Home = File.CreateText("bbHome.Score");
            Home.WriteLine("0");
            Home.Close();
            Away = File.CreateText("bbAway.Score");
            Away.WriteLine("0");
            Away.Close();
        }

        private void UpdateScore(object sender, RoutedEventArgs e)
        {
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void HomeFreeThrowButton(object sender, RoutedEventArgs e)
        {
            string BeforeHome = File.ReadAllText("bbHome.Score");
            int BeforeHomeScore = Int32.Parse(BeforeHome);
            int AfterHomeScore = BeforeHomeScore + 1;
            StreamWriter Home_Score;
            Home_Score = File.CreateText("bbHome.Score");
            Home_Score.WriteLine(AfterHomeScore);
            Home_Score.Close();
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void HomeTwoPointButton(object sender, RoutedEventArgs e)
        {
            string BeforeHome = File.ReadAllText("bbHome.Score");
            int BeforeHomeScore = Int32.Parse(BeforeHome);
            int AfterHomeScore = BeforeHomeScore + 2;
            StreamWriter Home_Score;
            Home_Score = File.CreateText("bbHome.Score");
            Home_Score.WriteLine(AfterHomeScore);
            Home_Score.Close();
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void HomeThreePointButton(object sender, RoutedEventArgs e)
        {
            string BeforeHome = File.ReadAllText("bbHome.Score");
            int BeforeHomeScore = Int32.Parse(BeforeHome);
            int AfterHomeScore = BeforeHomeScore + 3;
            StreamWriter Home_Score;
            Home_Score = File.CreateText("bbHome.Score");
            Home_Score.WriteLine(AfterHomeScore);
            Home_Score.Close();
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void AwayFreeThrowButton(object sender, RoutedEventArgs e)
        {
            string BeforeAway = File.ReadAllText("bbAway.Score");
            int BeforeAwayScore = Int32.Parse(BeforeAway);
            int AfterAwayScore = BeforeAwayScore + 1;
            StreamWriter Home_Score;
            Home_Score = File.CreateText("bbAway.Score");
            Home_Score.WriteLine(AfterAwayScore);
            Home_Score.Close();
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void AwayTwoPointButton(object sender, RoutedEventArgs e)
        {
            string BeforeAway = File.ReadAllText("bbAway.Score");
            int BeforeAwayScore = Int32.Parse(BeforeAway);
            int AfterAwayScore = BeforeAwayScore + 2;
            StreamWriter Home_Score;
            Home_Score = File.CreateText("bbAway.Score");
            Home_Score.WriteLine(AfterAwayScore);
            Home_Score.Close();
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void AwayThreePointButton(object sender, RoutedEventArgs e)
        {
            string BeforeAway = File.ReadAllText("bbAway.Score");
            int BeforeAwayScore = Int32.Parse(BeforeAway);
            int AfterAwayScore = BeforeAwayScore + 3;
            StreamWriter Home_Score;
            Home_Score = File.CreateText("bbAway.Score");
            Home_Score.WriteLine(AfterAwayScore);
            Home_Score.Close();
            string Home = File.ReadAllText("bbHome.Score");
            string Away = File.ReadAllText("bbAway.Score");
            int HomeScore = Int32.Parse(Home);
            int AwayScore = Int32.Parse(Away);
            if (HomeScore > AwayScore)
            {
                this.HomeScore.Background = Brushes.LightGreen;
                this.AwayScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore > HomeScore)
            {
                this.AwayScore.Background = Brushes.LightGreen;
                this.HomeScore.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
            if (AwayScore == HomeScore)
            {
                this.AwayScore.Background = Brushes.Yellow;
                this.HomeScore.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Score");
                string away = File.ReadAllText("bbAway.Score");
                this.HomeScore.Text = home;
                this.AwayScore.Text = away;
            }
        }

        private void CreateHomeFoulFile(object sender, RoutedEventArgs e)
        {
            StreamWriter Home;
            Home = File.CreateText("bbHome.Foul");
            Home.WriteLine("0");
            Home.Close();
        }

        private void CreateAwayFoulFile(object sender, RoutedEventArgs e)
        {
            StreamWriter Away;
            Away = File.CreateText("bbAway.Foul");
            Away.WriteLine("0");
            Away.Close();
        }

        private void HomeFoulButtonh(object sender, RoutedEventArgs e)
        {
            string BeforeHome = File.ReadAllText("bbHome.Foul");
            int BeforeHomeFoul = Int32.Parse(BeforeHome);
            int AfterHomeFoul = BeforeHomeFoul + 1;
            StreamWriter Home_Foul;
            Home_Foul = File.CreateText("bbHome.Foul");
            Home_Foul.WriteLine(AfterHomeFoul);
            Home_Foul.Close();
            string Home = File.ReadAllText("bbHome.Foul");
            string Away = File.ReadAllText("bbAway.Foul");
            int HomeFoul = Int32.Parse(Home);
            int AwayFoul = Int32.Parse(Away);
            if (HomeFoul > AwayFoul)
            {
                this.AwayFouls.Background = Brushes.LightGreen;
                this.HomeFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (AwayFoul > HomeFoul)
            {
                this.HomeFouls.Background = Brushes.LightGreen;
                this.AwayFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (HomeFoul == AwayFoul)
            {
                this.AwayFouls.Background = Brushes.Yellow;
                this.HomeFouls.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
        }

        private void AwayFoulButtona(object sender, RoutedEventArgs e)
        {
            string BeforeAway = File.ReadAllText("bbAway.Foul");
            int BeforeAwayFoul = Int32.Parse(BeforeAway);
            int AfterAwayFoul = BeforeAwayFoul + 1;
            StreamWriter Away_Foul;
            Away_Foul = File.CreateText("bbAway.Foul");
            Away_Foul.WriteLine(AfterAwayFoul);
            Away_Foul.Close();
            string Home = File.ReadAllText("bbHome.Foul");
            string Away = File.ReadAllText("bbAway.Foul");
            int HomeFoul = Int32.Parse(Home);
            int AwayFoul = Int32.Parse(Away);
            if (HomeFoul > AwayFoul)
            {
                this.AwayFouls.Background = Brushes.LightGreen;
                this.HomeFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (AwayFoul > HomeFoul)
            {
                this.HomeFouls.Background = Brushes.LightGreen;
                this.AwayFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (HomeFoul == AwayFoul)
            {
                this.AwayFouls.Background = Brushes.Yellow;
                this.HomeFouls.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
        }
        private void UpdateFoulsButton(object sender, RoutedEventArgs e)
        {
            string Home = File.ReadAllText("bbHome.Foul");
            string Away = File.ReadAllText("bbAway.Foul");
            this.HomeFouls.Text = Home;
            this.AwayFouls.Text = Away;
            int HomeFoul = Int32.Parse(Home);
            int AwayFoul = Int32.Parse(Away);
            if (HomeFoul > AwayFoul)
            {
                this.AwayFouls.Background = Brushes.LightGreen;
                this.HomeFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (AwayFoul > HomeFoul)
            {
                this.HomeFouls.Background = Brushes.LightGreen;
                this.AwayFouls.Background = Brushes.LightCoral;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
            if (HomeFoul == AwayFoul)
            {
                this.AwayFouls.Background = Brushes.Yellow;
                this.HomeFouls.Background = Brushes.Yellow;
                string home = File.ReadAllText("bbHome.Foul");
                string away = File.ReadAllText("bbAway.Foul");
                this.HomeFouls.Text = home;
                this.AwayFouls.Text = away;
            }
        }
    }
}
