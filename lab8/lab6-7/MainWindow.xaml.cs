﻿
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
using System.Globalization;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
            ComboBoxThemes.SelectionChanged += ThemeChange;
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

        }
        private void ButtonRu_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void ButtonEng_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string theme = null;
            if (ComboBoxThemes.SelectedIndex == 0)
                theme = "Resources/LightTheme";
            if (ComboBoxThemes.SelectedIndex == 1)
                theme = "Resources/DarkTheme";
            var uri = new Uri(theme + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDictionary = (ResourceDictionary)Application.LoadComponent(uri);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();

        }


        private void Show_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow outputWindow = new OutputWindow();
            outputWindow.Show();
            this.Hide();
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            AddItems AddWindow = new AddItems();

            AddWindow.ShowDialog();
        }

        private void lab8(object sender, RoutedEventArgs e)
        {
            Lab8 laba8 = new Lab8();
            laba8.Show();
            this.Hide();
        }
    }
}
