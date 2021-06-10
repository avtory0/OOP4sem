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
using static lab6_7.AddItems;


namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        List<Item> items = new List<Item>();
        int numItem = 0;
        public EditWindow(List<Item> items, object numItem)
        {
            InitializeComponent();

            this.items = items;
            this.numItem = (int)numItem;
            int counter = 0;
            foreach (var item in items)
            {
                if (counter == this.numItem)
                {
                    Name.Text = item.Name;
                    Price.Text = item.Price.ToString();
                    Category.Text = item.Category;
                    if (item.IsAvailable == "New")
                        RadioButtonNew.IsChecked = true;
                    else
                        RadioButtonUsed.IsChecked = true;
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(item.PicturePath);
                    image.EndInit();
                    Preview.Source = image;
                    break;
                }
                counter++;
            }
        }

        //public EditWindow(List<Cars> items, object numItem)
        //{
        //    InitializeComponent();
        //    this.item = items;
        //    this.numItem = (int)numItem;
        //    int counter = 0;
        //    foreach (var item in items)
        //    {
        //        if (counter == this.numItem)
        //        {
        //            Name.Text = item.NameItem;
        //            Price.Text = item.Price.ToString();
        //            Category.Text = item.Category;
        //            if (item.IsAvailable == "New")
        //                RadioButtonNew.IsChecked = true;
        //            else
        //                RadioButtonUsed.IsChecked = true;
        //            Description.Text = item.Description;
        //            BitmapImage image = new BitmapImage();
        //            image.BeginInit();
        //            image.UriSource = new Uri(item.PicturePath);
        //            image.EndInit();
        //            Preview.Source = image;
        //            break;
        //        }
        //        counter++;
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int counter = 0;
                foreach (var item in items)
                {
                    if (numItem == counter)
                    {
                        item.Name = Name.Text;
                        item.Category = Category.Text;
                        if (Double.TryParse(Price.Text, out double result))
                            item.Price = result;
                        item.PicturePath = Preview.Source.ToString();
                        if (RadioButtonNew.IsChecked == true)
                            item.IsAvailable = TextBlockNew.ToString();
                        if (RadioButtonUsed.IsChecked == true)
                            item.IsAvailable = TextBlockUsed.ToString();
                        break;
                    }
                    counter++;
                }
                XmlSerializeWrapper.Serialize(items, "cars.xml");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка записи в файл!");
                return;
            }
            MessageBox.Show("Информация о товаре изменена!");

            this.Hide();

            this.DialogResult = true;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = string.Empty;
            Price.Text = string.Empty;
            Category.SelectedIndex = -1;
            Preview.Source = null;
            Description.Text = string.Empty;
        }

        private void Price_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
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
    }
}
