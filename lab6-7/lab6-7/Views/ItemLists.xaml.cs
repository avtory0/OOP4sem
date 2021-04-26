using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static lab6_7.AddItems;


namespace lab6_7.Views
{
    /// <summary>
    /// Логика взаимодействия для ItemLists.xaml
    /// </summary>
    public partial class ItemLists : UserControl
    {
        CarsList carslist = new CarsList();
        ObservableCollection<Cars> items = new ObservableCollection<Cars>();
        FoodListHistory history = new FoodListHistory();
        public ItemLists()
        {
            InitializeComponent();

            carslist = Serializer.MyXMLDeserializer();
            ListView.ItemsSource = carslist.list;
        }

        private void TextBoxMinPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void TextBoxMaxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
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

        private void ButtonDeleteitems_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int counter = 0;
            foreach (Cars cars in carslist.list)
            {
                if (counter == ListView.SelectedIndex)
                {
                    items.RemoveAt(counter);
                    Serializer.MyXMLSerializer(carslist);
                    MessageBox.Show($"Товар {cars.NameItem} удалён!");
                    break;
                }
                counter++;
            }
            ListView.ItemsSource = carslist.list;
        }

        //private void ButtonChange_Click(object sender, RoutedEventArgs e)
        //{
        //    EditWindow window = new EditWindow(items, ListView.SelectedIndex);
        //    window.Show();
        //}

        public static implicit operator Window(ItemLists v)
        {
            throw new NotImplementedException();
        }
    }
}
