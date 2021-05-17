using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Globalization;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        List<Cars> item = new List<Cars>();
        CarsList carslist = new CarsList();
        ObservableCollection<Cars> items = new ObservableCollection<Cars>();
        //FoodListHistory history = new FoodListHistory();
        public OutputWindow()
        {
            InitializeComponent();

            carslist = Serializer.MyXMLDeserializer();
            ListView.ItemsSource = carslist.list;
            ComboBoxThemes.SelectionChanged += ThemeChange;


            CommandBinding commandAdd = new CommandBinding();
            commandAdd.Command = ApplicationCommands.New;
            commandAdd.Executed += AddItem_Click;
            Add.CommandBindings.Add(commandAdd);

            CommandBinding commandHome = new CommandBinding();
            commandHome.Command = ApplicationCommands.New;
            commandHome.Executed += Home_Click;
            Home.CommandBindings.Add(commandHome);

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
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddItems window = new AddItems();
            window.ShowDialog();

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Hide();
            
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            carslist = Serializer.MyXMLDeserializer();
            CarsList foodTempList = new CarsList();
            foreach (Cars food in carslist.list)
            {
                string pattern1 = @"^" + serchBox.Text + @"\w*";
                if (food.NameItem == serchBox.Text)
                {
                    foodTempList.list.Add(food);
                }
                else if (Regex.IsMatch(food.NameItem, pattern1))
                {
                    foodTempList.list.Add(food);
                }
            }
            ListView.ItemsSource = foodTempList.list;
        }

        private void ShowAll_click(object sender, RoutedEventArgs e)
        {
            serchBox.Text = string.Empty;
            carslist = Serializer.MyXMLDeserializer();
            ListView.ItemsSource = carslist.list;
        }


        private void DeleteItem_click(object sender, RoutedEventArgs e)
        {
            carslist.list.Remove((Cars)ListView.SelectedItem);
            Serializer.MyXMLSerializer(carslist);
            MessageBox.Show($"Товар удалён!");
        }

        private void EditItem_click(object sender, RoutedEventArgs e)
        {
            //EditWindow editWindow = new EditWindow(item, ListView.SelectedIndex);
            //editWindow.Show();

            EditWindow editWindow = new EditWindow();
            editWindow.Owner = this;
            Cars tempCars = (Cars)ListView.SelectedItem;
            if (ListView.SelectedItem != null)
            {
                if (editWindow.ShowDialog() == true)
                {
                    //history.History.Push(foodList.Save());
                    tempCars = new Cars();
                    tempCars.NameItem = editWindow.Name.Text;
                    tempCars.PicturePath = editWindow.Preview.Source.ToString();
                    tempCars.Price = Math.Abs(float.Parse(editWindow.Price.Text));
                    tempCars.Description = editWindow.Description.Text;
                    tempCars.Category = editWindow.Category.SelectedValue.ToString();
                    if (editWindow.RadioButtonNew.IsChecked == true)
                        tempCars.IsAvailable = editWindow.TextBlockNew.Text;
                    if (editWindow.RadioButtonUsed.IsChecked == true)
                        tempCars.IsAvailable = editWindow.TextBlockUsed.Text;
                    foreach (Cars food in carslist.list)
                    {
                        if (food == (Cars)ListView.SelectedItem)
                        {
                            carslist.list[carslist.list.IndexOf(food)] = tempCars;
                            break;
                        }
                    }
                    Serializer.MyXMLSerializer(carslist);
                    ListView.ItemsSource = carslist.list;

                }
            }


        }

        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }

        private void ButtonRedo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

