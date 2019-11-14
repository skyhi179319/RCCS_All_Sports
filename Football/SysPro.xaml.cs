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
    /// Interaction logic for SysPro.xaml
    /// </summary>
    public partial class SysPro : Window
    {
        public SysPro()
        {
            InitializeComponent();
        }

        private void dotsave(object sender, MouseButtonEventArgs e)
        {
            StreamWriter Save;
            Save = File.CreateText("info.info");
            Save.WriteLine("Version 1.2.2");
            Save.WriteLine("For Windows 10");
            Save.WriteLine("Miminal Size Best Suits Program");
            Save.WriteLine("Created By Skyler Barr");
            Save.Close();
        }

        private void Load(object sender, MouseButtonEventArgs e)
        {
            string text = File.ReadAllText("info.info");
            var output = text;
            var box = this.Text;
            box.FontSize = 13;
            box.Text = output;
        }
    }
}
