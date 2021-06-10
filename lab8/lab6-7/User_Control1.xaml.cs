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
    /// Логика взаимодействия для User_Control1.xaml
    /// </summary>
    public partial class User_Control1 : UserControl
    {
        public User_Control1()
        {
            InitializeComponent();

        }
        private void buttonTBox_Click(object sender, RoutedEventArgs e)
        {
            userTBox.Text = string.Empty;
            userTBox.Focus();
        }
    }
}
