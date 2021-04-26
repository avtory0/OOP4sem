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
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;


namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для AddItems.xaml
    /// </summary>
    public partial class AddItems : Window
    {
        Cars cars = new Cars();
        CarsList carslist = new CarsList();
        public AddItems()
        {
            InitializeComponent();

        }

       

        private void OpenExplore(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    Preview.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
                    cars.PicturePath = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Выберите файл формата", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                carslist = Serializer.MyXMLDeserializer();
            }
            catch
            {

            }
            if (cars.PicturePath == null)
            {
                MessageBox.Show("Выберите фотографию", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                cars.NameItem = Name.Text;
                cars.Category = Category.SelectedValue.ToString();
                try
                {
                    if (float.TryParse(Price.Text, out float price))
                        cars.Price = price;
                    else
                        throw new Exception("incorrect data in the price input");
                    if (RadioButtonNew.IsChecked == true)
                        cars.IsAvailable = TextBlockNew.Text;
                    if (RadioButtonUsed.IsChecked == true)
                        cars.IsAvailable = TextBlockUsed.Text;
                    cars.Description = Description.Text;
                    carslist.AddItem(cars);
                    Serializer.MyXMLSerializer(carslist);
                    cars = new Cars();

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Некорректный формат цены.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            //try
            //{

            //    cars.NameItem = Name.Text;
            //    cars.Category = Category.Text;
            //    if (float.TryParse(Price.Text, out float price))
            //        cars.Price = price;
            //    else
            //        throw new Exception("incorrect data in the price input");
            //    if (RadioButtonNew.IsChecked == true)
            //        cars.IsAvailable = TextBlockNew.Text;
            //    if (RadioButtonUsed.IsChecked == true)
            //        cars.IsAvailable = TextBlockUsed.Text;
            //    cars.Description = Description.Text;
            //    cars.PicturePath = Preview.Source.ToString();
            //    carslist.Add(cars);
            //    XmlSerializeWrapper.Serialize(carslist, "cars.xml");    
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ошибка записи в файл!");
            //    return;
            //}
            //MessageBox.Show($"Товар добавлен в корзину!\nКоличество товаров в корзине : {carslist.Count}");

        }




        private void Price_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = string.Empty;
            Price.Text = string.Empty;
            Category.SelectedIndex = -1;
            Preview.Source = null;
            Description.Text = string.Empty;
            
        }

        
    }
}
