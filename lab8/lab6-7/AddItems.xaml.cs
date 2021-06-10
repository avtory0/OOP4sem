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
        List<Item> itemsCollection = new List<Item>();
        List<Item> lastItems = new List<Item>();
        Item lastItem = new Item();
        public AddItems()
        {
            InitializeComponent();

        }

        [Serializable]
        public class Item
        {
            [XmlElement(ElementName = "name_of_item")]
            public string Name { get; set; }
            [XmlElement(ElementName = "category_of_item")]
            public string Category { get; set; }
            [XmlElement(ElementName = "price_for_one_kg")]
            public double Price { get; set; }
            [XmlElement(ElementName = "origin_country")]
            public string Country { get; set; }
            [XmlElement(ElementName = "is_alailable")]
            public string IsAvailable { get; set; }
            [XmlIgnore]
            public string Description { get; set; }
            [XmlElement(ElementName = "path_of_picture")]
            public string PicturePath { get; set; }
        }

        public static class XmlSerializeWrapper
        {
            public static void Serialize<T>(T obj, string filename)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            public static T Deserialize<T>(string filename)
            {
                T obj;
                if (File.Exists(filename))
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        obj = (T)serializer.Deserialize(fs);
                    }
                    return obj;
                }
                return default(T);
            }
        }

        private void OpenExplore(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = ""; // Default file name
            dlg.DefaultExt = ".png"; // Default file extension
                                     //    dlg.Filter = "Pictures (.png,jpg)|*.png,*.jpg"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(dlg.FileName);
                image.EndInit();
                Preview.Source = image;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Item tempItem = new Item();
                tempItem.Name = Name.Text;
                tempItem.Category = Category.Text;
                if (float.TryParse(Price.Text, out float price))
                    tempItem.Price = price;
                else
                    throw new Exception("incorrect data in the price input");
                if (RadioButtonNew.IsChecked == true)
                    tempItem.IsAvailable = TextBlockNew.Text;
                if (RadioButtonUsed.IsChecked == true)
                    tempItem.IsAvailable = TextBlockUsed.Text;
                tempItem.Description = Description.Text;
                tempItem.PicturePath = Preview.Source.ToString();
                lastItem = tempItem;
                itemsCollection.Add(tempItem);
                lastItems.Add(tempItem);
                ButtonUndo.IsEnabled = true;
                ButtonRedo.IsEnabled = true;
                XmlSerializeWrapper.Serialize(itemsCollection, "cars.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка записи в файл!");
                return;
            }
            MessageBox.Show($"Товар добавлен в корзину!\nКоличество товаров в корзине : {itemsCollection.Count}");


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

        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lastItems.RemoveAt(lastItems.Count - 1);
                itemsCollection.RemoveAt(itemsCollection.Count - 1);
                MessageBox.Show($"Последний добавленный элемент ({lastItem.Name}) удален!");
                XmlSerializeWrapper.Serialize(itemsCollection, "cars.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Вы удалили все только что добавленные товары!");
                ButtonUndo.IsEnabled = false;
            }
        }

        private void ButtonRedo_Click(object sender, RoutedEventArgs e)
        {
            itemsCollection.Add(lastItem);
            lastItems.Add(lastItem);
            XmlSerializeWrapper.Serialize(itemsCollection, "cars.xml");
            MessageBox.Show($"Последний добавленный элемент ({lastItem.Name}) добавлен!");
        }

       
    }
}
