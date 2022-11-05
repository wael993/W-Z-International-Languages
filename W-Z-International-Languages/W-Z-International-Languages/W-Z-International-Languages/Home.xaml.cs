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
using System.Windows.Shapes;

namespace W_Z_International_Languages
{
    /// <summary>
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Window
    {
       
        public Home()
        {
            InitializeComponent();
        }

     

        private void MenuItem_GotFocus(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Registration_Click(object sender, RoutedEventArgs e)
        {
            Student_Registration.Visibility = Visibility.Visible;
            Student_Mang1.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Manage_Student_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang1.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;

        }
    }
}
