using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
        private ICollectionView CollectionView;
        W_Z_International_LanguagesEntities1 ctx = new W_Z_International_LanguagesEntities1();

        public Home()
        {
            InitializeComponent();
            ctx.course.Load();
            CollectionView = CollectionViewSource.GetDefaultView(ctx.course.Local);
            Parents_Grid.DataContext = CollectionView;
            Student_Registration.DataContext = ctx.student.ToList();
        }

        //private void studenteinladen()
        //{
        //    ctx.student.Load();
        //    CollectionView = CollectionViewSource.GetDefaultView(ctx.student.Local);
        //    Student_Registration.DataContext = CollectionView;

        //}

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
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;

        }
        private void MenuItem_view_Student_Click(object sender, RoutedEventArgs e)
        {
            View_Student.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;
            Student_Mang.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;


        }
        private void MenuItem_Registration_Click(object sender, RoutedEventArgs e)
        {
            //studenteinladen();
            Student_Registration.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Manage_Student_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;

        }
        private void View_Course_Click(object sender, RoutedEventArgs e)
        {
            View_Course.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
        }
        private void New_Course_Click(object sender, RoutedEventArgs e)
        {
            New_Course.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;

        }

        private void Mang_Course_Click(object sender, RoutedEventArgs e)
        {
            Mang_Course.Visibility = Visibility.Visible;
            New_Course.Visibility = Visibility.Hidden;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
        }

        private void tbx_View_Student_search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_View_Student_search.Text == "Search")
            {
                tbx_View_Student_search.Text = "";
            }
        }
   
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
        private void MenuItem_Student_Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dlg = new PrintDialog();

            Window currentMainWindow = Application.Current.MainWindow;

            Application.Current.MainWindow = this;

            if ((bool)dlg.ShowDialog().GetValueOrDefault())
            {
                Application.Current.MainWindow = currentMainWindow;
                dlg.PrintVisual(DG_Student, "Auftrag_Nr");

            }

        }
        private void tbx_view_Course_Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_view_Course_Search.Text == "Search")
            {
                tbx_view_Course_Search.Text = "";
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

       

        private void MenuItem_Course_Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dlg = new PrintDialog();

            Window currentMainWindow = Application.Current.MainWindow;

            Application.Current.MainWindow = this;

            if (dlg.ShowDialog().GetValueOrDefault())
            {
                Application.Current.MainWindow = currentMainWindow;
                dlg.PrintVisual(DG_View_Course, "Auftrag_Nr");

            }
        }

        private void Btn_New_Student_Clear_Click(object sender, RoutedEventArgs e)
        {
            TB_New_First_Name.Text = "";
            TB_New_Address.Text = "";
            TB_New_Phane.Text = "";
            TB_New_Last_Name.Text = "";
            New_birthday.SelectedDate = null;
        }

        private void BT_StudentClear_Click(object sender, RoutedEventArgs e)
        {
            TB_Mang_First_Name.Text = "";
            TB_Mang_Address.Text = "";
            TB_Mang_Last_Name.Text = "";
            TB_Mang_Phane.Text = "";
            Mang_birthday.SelectedDate = null;
        }

        private void Btn_NewCourse_Clear_Click(object sender, RoutedEventArgs e)
        {
            TB_NewCourse_Name.Text = "";
            TB_NewCourse_Hour.Text = "";
            TB_NewCourse_Description.Text = "";
            
        }

        private void Btn_MangCourse_Clear_Click(object sender, RoutedEventArgs e)
        {
            TB_MangCourse_Name.Text = "";
            TB_MangCourse_Hour.Text = "";
            TB_MangCourse_Description.Text = "";

        }
    }
}
