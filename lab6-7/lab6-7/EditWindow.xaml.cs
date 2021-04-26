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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        List<Cars> item = new List<Cars>();
        int numItem = 0;
        Cars cars = new Cars();
        CarsList carslist = new CarsList();
        public EditWindow()
        {
            InitializeComponent();
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
            //try
            //{
            //    int counter = 0;
            //    foreach (var item in item)
            //    {
            //        if (numItem == counter)
            //        {
            //            item.NameItem = Name.Text;
            //            if (Double.TryParse(Price.Text, out double result))
            //                item.Price = result;
            //            item.Category = Category.Text;
            //            item.Description = Description.Text;
            //            item.PicturePath = Preview.Source.ToString();
            //            if (RadioButtonNew.IsChecked == true)
            //                item.IsAvailable = "New";
            //            if (RadioButtonUsed.IsChecked == true)
            //                item.IsAvailable = "Used";
            //            break;
            //        }
            //        counter++;
            //    }
            //    Serializer.MyXMLSerializer(carslist);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show($"Ошибка записи в файл!");
            //    return;
            //}
            //MessageBox.Show("Информация о товаре изменена!");

            //this.Hide();

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
    }
}
