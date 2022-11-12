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
            New_Course.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Manage_Student_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang1.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;

        }

        private void Dashboard_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang1.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;

        }

        private void Course_Click(object sender, RoutedEventArgs e)
        {
            New_Course.Visibility = Visibility.Visible;
            Student_Mang1.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
        }

        private void tbx_search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_search.Text == "search")
            {
                tbx_search.Text = "";
            }
        }

        private void tbx_Search_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if (tbx_Search.Text == "search")
            {
                tbx_Search.Text = "";
            }
        }

        private void tbxs_Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_Search.Text == "search")
            {
                tbx_Search.Text = "";
            }

        }

     

     
    }
}
