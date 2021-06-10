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
    [Serializable]
    public class Cars
    {
    //    [XmlElement(ElementName = "name_of_cars")]
    //    public string NameItem { get; set; }
    //    [XmlElement(ElementName = "category_of_cars")]
    //    public string Category { get; set; }
    //    [XmlElement(ElementName = "price_of_cars")]
    //    public double Price { get; set; }

    //    [XmlElement(ElementName = "is_alailable")]
    //    public string IsAvailable { get; set; }
    //    [XmlIgnore]
    //    public string Description { get; set; }
    //    [XmlElement(ElementName = "path_of_picture")]
    //    public string PicturePath { get; set; }

    //    public Cars()
    //    {

    //    }
    //    public Cars(string nameItem, string category, double price, string isAvailable, string description, string picturePath)
    //    {
    //        this.NameItem = nameItem;
    //        this.Category = category;
    //        this.Price = price;
    //        this.IsAvailable = isAvailable;
    //        this.Description = description;
    //        this.PicturePath = picturePath;
    //    }

    //    public Cars Clone()
    //    {
    //        return new Cars(this.NameItem, this.Category, this.Price, this.IsAvailable, this.Description, this.PicturePath);
    //    }
    //}

    //public class CarsList
    //{
    //    [XmlArray("Collection"), XmlArrayItem("Item")]
    //    public ObservableCollection<Cars> list { get; set; }
    //    public ObservableCollection<Cars> tempList { get; set; }
    //    public CarsList()
    //    {
    //        list = new ObservableCollection<Cars> { };
    //    }
    //    public void AddItem(Cars obj)
    //    {
    //        list.Add(obj.Clone());
    //    }
        //public void ListClone()
        //{
        //    if (tempList != null)
        //    {
        //        tempList.Clear();
        //    }

        //    foreach (Cars food in this.list)
        //    {
        //        tempList.Add(food.Clone());
        //    }
        //}
        //public CarsListMemento Save()
        //{
        //    ListClone();
        //    return new CarsListMemento(tempList);
        //}
    }
    //public class CarsListMemento
    //{
    //    public ObservableCollection<Cars> List { get; private set; }

    //    public CarsListMemento(ObservableCollection<Cars> list)
    //    {
    //        this.List = list;
    //    }
    //}

    //public class FoodListHistory
    //{
    //    public Stack<CarsListMemento> History { get; private set; }
    //    public FoodListHistory()
    //    {
    //        History = new Stack<CarsListMemento>();
    //    }
    //}

    //public static class XmlSerializeWrapper
    //{
    //    public static void Serialize<T>(T obj, string filename)
    //    {
    //        XmlSerializer formatter = new XmlSerializer(typeof(T));
    //        using (FileStream fs = new FileStream(filename, FileMode.Create))
    //        {
    //            formatter.Serialize(fs, obj);
    //        }
    //    }
    //    public static T Deserialize<T>(string filename)
    //    {
    //        T obj;
    //        if (File.Exists(filename))
    //        {
    //            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
    //            {
    //                XmlSerializer serializer = new XmlSerializer(typeof(T));
    //                obj = (T)serializer.Deserialize(fs);
    //            }
    //            return obj;
    //        }
    //        return default(T);
    //    }
    //}

    //internal static T MyXMLDeserializer<T>()
    //{
    //    throw new NotImplementedException();
    //}


}

