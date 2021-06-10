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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для User_Control2.xaml
    /// </summary>
    public partial class User_Control2 : UserControl
    {
        public User_Control2()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public static readonly DependencyProperty TextProperty;

        static User_Control2()
        {
            TextProperty = DependencyProperty.Register("placeholder", typeof(string), typeof(User_Control2), new PropertyMetadata(default(string)));
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(Correct);
            //TextProperty = DependencyProperty.Register("placeholder", typeof(string), typeof(User_Control2), metadata, new ValidateValueCallback(Validate));
        }

        private static bool Validate(object value)
        {
            if (value == null)
                return false;
            string currentValue = value.ToString();
            if (currentValue.Length >= 0)
                return true;
            return false;
        }

        private static object Correct(DependencyObject d, object baseV)
        {
            string line = baseV.ToString();
            if (line.Length > 20)
                return line.Substring(0, 20);
            return false;
        }
    }
}
