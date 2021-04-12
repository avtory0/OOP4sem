using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static lab6_7.AddItems;


namespace lab6_7.Views
{
    /// <summary>
    /// Логика взаимодействия для ItemLists.xaml
    /// </summary>
    public partial class ItemLists : UserControl
    {
        ObservableCollection<Cars> cars = new ObservableCollection<Cars>();
        public ItemLists()
        {
            InitializeComponent();

            cars = XmlSerializeWrapper.Deserialize<ObservableCollection<Cars>>("cars.xml");
            ListView.ItemsSource = cars;
        }

        //private void Toolbar(object sender, MouseButtonEventArgs e)
        //{
        //    carslist = Serializer.MyXMLDeserializer();
        //    AllItems.ItemsSource = carslist.list;
        //}


        //private void LastItemInfo()
        //{
        //     carslist = Serializer.MyXMLDeserializer();
        //     lastGoodImg.Source = new BitmapImage(new Uri(carslist.Last().photo, UriKind.Absolute));
        //     ItemName.Text = carslist.Last().name;
        //     IteamDesc.Text = foodList.Last().description;
        //     ItemPrice.Text = String.Format("{0:F2} руб", foodList.Last().price);
            
        //}

        //private void ShowAll_Click(object sender, RoutedEventArgs e)
        //{
        //    carslist = Serializer.MyXMLDeserializer();
        //    AllItems.ItemsSource = carslist.list;
        //}

        //private void DeleteItems_Click(object sender, RoutedEventArgs e)
        //{
        //    carslist.list.Remove((Cars)AllItems.SelectedItem);
        //    Serializer.MyXMLSerializer(carslist);
        //    //LastItemInfo();
        //}
    }
}
