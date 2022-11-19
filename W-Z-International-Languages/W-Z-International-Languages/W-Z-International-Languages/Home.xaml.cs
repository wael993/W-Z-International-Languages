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
            var student = ctx.student.ToList();
            Student_Registration.DataContext = student;
            View_Student.DataContext = student;
            Student_Mang.DataContext = student;

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
            Student_Information.Visibility = Visibility.Hidden;

        }
        private void MenuItem_view_Student_Click(object sender, RoutedEventArgs e)
        {
            View_Student.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;
            Student_Mang.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;


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
            Student_Information.Visibility = Visibility.Hidden;

        }

        private void MenuItem_Manage_Student_Click(object sender, RoutedEventArgs e)
        {
            Student_Mang.Visibility = Visibility.Visible;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;

        }
        private void View_Course_Click(object sender, RoutedEventArgs e)
        {
            View_Course.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;

        }
        private void New_Course_Click(object sender, RoutedEventArgs e)
        {
            New_Course.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;

        }

        private void Mang_Course_Click(object sender, RoutedEventArgs e)
        {
            Mang_Course.Visibility = Visibility.Visible;
            New_Course.Visibility = Visibility.Hidden;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;

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

        private void Btn_StudentUpdat_Click(object sender, RoutedEventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Änderung wird gespeichert.");
        }

        private void Btn_MangCourse_Updat_Click(object sender, RoutedEventArgs e)
        {
            ctx.SaveChanges();
            MessageBox.Show("Änderung wird gespeichert.");
        }

        private void Btn_StudentDelet_Click(object sender, RoutedEventArgs e)
        {
            int Hidde_St_ID = Convert.ToInt32(Hidden_St_ID.Content);

            if (MessageBox.Show("Do you really want to delete the student?",
                      "Save file",
                      MessageBoxButton.YesNo,
                      MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (Hidde_St_ID== 1000)
                {
                    MessageBox.Show("you can't delete an admin !!");
                }
                else
                {
                    course_student n = ctx.course_student.Where(x => x.student_id == Hidde_St_ID).FirstOrDefault();
                    ctx.course_student.Remove(n);
                    student w = ctx.student.Where(x => x.student_id == Hidde_St_ID).FirstOrDefault();
                    ctx.student.Remove(w);
                    ctx.SaveChanges();
                    var list = ctx.student.ToList();
                    Student_Mang.DataContext = null;
                    Student_Mang.DataContext = list;
                }
            }


        }

        private void Btn_New_Student_Add_Click(object sender, RoutedEventArgs e)
        {
            bool gen;
            if (CB_New_Gender.Text== "Male")
            {
                gen = true;
            }
            else
            {
                gen = false;
            }
            if (TB_New_First_Name.Text == "" || TB_New_Last_Name.Text == "" || New_birthday.Text == "" ||
               TB_New_Phane.Text == "" || TB_New_Address.Text == "")
            {
                MessageBox.Show("Please check your input.");
            }
            else
            {
                student student = new student
                {
                    FirstName = TB_New_First_Name.Text,
                    LastName = TB_New_Last_Name.Text,
                    Birthday = New_birthday.DisplayDate,
                    Gender = gen,
                    Phone = TB_New_Phane.Text,
                    Adress = TB_New_Address.Text,

                };
                ctx.student.Add(student);
                ctx.SaveChanges();
                var Student = ctx.student.ToList();
                Student_Registration.DataContext = null;
                Student_Registration.DataContext = Student;

                TB_New_First_Name.Text = "";
                TB_New_Last_Name.Text = "";
                New_birthday.Text = "";
                CB_New_Gender.Text = "";
                TB_New_Phane.Text = "";
                TB_New_Address.Text = "";

                MessageBox.Show("Neu Student wird hinzugefügt.");

            }

            }

        private void DG_Student_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int Hidde_St_ID = Convert.ToInt32(Label_student_ID.Content);
            student w = ctx.student.Where(x => x.student_id == Hidde_St_ID).FirstOrDefault();
            Student_Information.DataContext = w;


            Student_Information.Visibility = Visibility.Visible;
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
        }
    }
}
