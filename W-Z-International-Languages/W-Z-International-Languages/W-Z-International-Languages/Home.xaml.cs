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

        private void Dashboard_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            //View_Student.Visibility = Visibility.Hidden;

        }
        //private void MenuItem_view_Student_Click(object sender, RoutedEventArgs e)
        //{
        //    View_Student.Visibility = Visibility.Hidden;
        //    Student_Registration.Visibility = Visibility.Hidden;
        //    Student_Mang.Visibility = Visibility.Hidden;
        //    New_Course.Visibility = Visibility.Hidden;
        //    Mang_Course.Visibility = Visibility.Hidden;
        //}
        private void MenuItem_Registration_Click(object sender, RoutedEventArgs e)
        {
            Student_Registration.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            //View_Student.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Manage_Student_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            //View_Student.Visibility = Visibility.Hidden;

        }

        private void New_Course_Click(object sender, RoutedEventArgs e)
        {
            New_Course.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            //View_Student.Visibility = Visibility.Hidden;

        }

        private void Mang_Course_Click(object sender, RoutedEventArgs e)
        {
            Mang_Course.Visibility = Visibility.Visible;
            New_Course.Visibility = Visibility.Hidden;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            //View_Student.Visibility = Visibility.Hidden;

        }

        //private void tbx_View_Student_search_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    if (tbx_View_Student_search.Text == "Search")
        //    {
        //        tbx_View_Student_search.Text = "";
        //    }
        //}
        private void tbx_Student_Registration_search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_Student_Registration_search.Text == "Search")
            {
                tbx_Student_Registration_search.Text = "";
            }
        }

        private void tbx_Student_Mang_Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_Student_Mang_Search.Text == "Search")
            {
                tbx_Student_Mang_Search.Text = "";
            }
        }
        
        private void tbx_New_Course_Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_New_Course_Search.Text == "Search")
            {
                tbx_New_Course_Search.Text = "";
            }
        }

        private void tbx_Mang_Course_Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_Mang_Course_Search.Text == "Search")
            {
                tbx_Mang_Course_Search.Text = "";
            }
        }

    
    }
}
