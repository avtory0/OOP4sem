using System;

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace lab6_7
{
    [Serializable]
    class Cars
    {
        [XmlElement(ElementName = "name_of_cars")]
        public string NameItem { get; set; }
        [XmlElement(ElementName = "category_of_cars")]
        public string Category { get; set; }
        [XmlElement(ElementName = "price_of_cars")]
        public double Price { get; set; }

        [XmlElement(ElementName = "is_alailable")]
        public string IsAvailable { get; set; }
        [XmlIgnore]
        public string Description { get; set; }
        [XmlElement(ElementName = "path_of_picture")]
        public string PicturePath { get; set; }
    }

    public class CarsList
    {
        [XmlArray("Collection"), XmlArrayItem("Airline")]
        public ObservableCollection<Cars> cars { get; set; }
        public CarsList()
        {
            list = new ObservableCollection<Airline> { };
        }

        public void AddItem(Airline obj)
        {
            list.Add(obj.Clone());
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
        //public Food Last()
        //{
        //    return list[list.Count - 1];
        //}
    }

    public static class Serializer
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

                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    obj = (T)serializer.Deserialize(fs);
                }
                return obj;

            }
        }
    
}
