using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
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
        W_Z_International_LanguagesEntities31 ctx = new W_Z_International_LanguagesEntities31();

        public Home()
        {
            InitializeComponent();
            ctx.course.Load();
            CollectionView = CollectionViewSource.GetDefaultView(ctx.course.Local);
            var student = ctx.student.ToList();
            Student_Registration.DataContext = student;
            Student_Mang.DataContext = student;
           
        }
        public void show()
        {
            Student_Mang.Visibility = Visibility.Hidden;
            Student_Registration.Visibility = Visibility.Hidden;
            New_Course.Visibility = Visibility.Hidden;
            Mang_Course.Visibility = Visibility.Hidden;
            View_Student.Visibility = Visibility.Hidden;
            View_Course.Visibility = Visibility.Hidden;
            Student_Information.Visibility = Visibility.Hidden;

        }
        private void AboutW_Z_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/wael993/W-Z-International-Languages.git");

        }
        private void DG_Student_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {          
            int student_id_h = Convert.ToInt32(Label_student_ID.Text);
            course_student n = ctx.course_student.Where(x => x.student_id == student_id_h).FirstOrDefault();
            Student_Information.DataContext = n;

            show();
            Student_Information.Visibility = Visibility.Visible;
        }

       

        private void MenuItem_GotFocus(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Dashboard_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            show();
        }
        private void MenuItem_view_Student_Click(object sender, RoutedEventArgs e)
        {
            ctx.student.Load();
            CollectionView = CollectionViewSource.GetDefaultView(ctx.student.Local);
            View_Student.DataContext = CollectionView;
         
            show();
            View_Student.Visibility = Visibility.Visible;


        }
        private void MenuItem_Registration_Click(object sender, RoutedEventArgs e)
        {
            ctx.student.Load();
            CollectionView = CollectionViewSource.GetDefaultView(ctx.student.Local);
             Student_Registration.DataContext = CollectionView;

            show();
            Student_Registration.Visibility = Visibility.Visible;
        }

        private void MenuItem_Manage_Student_Click(object sender, RoutedEventArgs e)
        {
            ctx.student.Load();
            CollectionView = CollectionViewSource.GetDefaultView(ctx.student.Local);
            Student_Mang.DataContext = CollectionView;

            show();
            Student_Mang.Visibility = Visibility.Visible;

        }
        public void cours()
        {
        ctx.course.Load();
            CollectionView = CollectionViewSource.GetDefaultView(ctx.course.Local);


        }
        private void View_Course_Click(object sender, RoutedEventArgs e)
        {
            cours();
            View_Course.DataContext = CollectionView;
            show();

            View_Course.Visibility = Visibility.Visible;

        }
        private void New_Course_Click(object sender, RoutedEventArgs e)
        {
            cours();
            New_Course.DataContext = CollectionView;

            show();
            New_Course.Visibility = Visibility.Visible;

        }

        private void Mang_Course_Click(object sender, RoutedEventArgs e)
        {
            cours();
            Mang_Course.DataContext = CollectionView;

            show();
            Mang_Course.Visibility = Visibility.Visible;

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
            New_birthday.Text = "";
        }

        private void BT_StudentClear_Click(object sender, RoutedEventArgs e)
        {
            TB_Mang_First_Name.Text = "";
            TB_Mang_Address.Text = "";
            TB_Mang_Last_Name.Text = "";
            TB_Mang_Phane.Text = "";
            Mang_birthday.Text = "";
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
                    Birthday = New_birthday.Text,
                    Gender = CB_Mang_Gender.Text,
                    Phone = TB_New_Phane.Text,
                    Adress = TB_New_Address.Text,

                };
                ctx.student.Add(student);
                ctx.SaveChanges();

                //course_student _course_Student = new course_student();




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

        private void tbx_Student_Registration_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchStr = tbx_Student_Registration_search.Text.ToLower();
            var list = CollectionView.Cast<student>();
            student q = list.FirstOrDefault(x => x.FirstName.ToLower().Contains(searchStr)
                        || x.LastName.ToLower().Contains(searchStr)
                        || x.Birthday.ToString().Contains(searchStr));
            CollectionView.MoveCurrentTo(q);

        }

        private void tbx_Student_Mang_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchStr = tbx_Student_Mang_Search.Text.ToLower();

            var list = CollectionView.Cast<student>();
            student n = list.FirstOrDefault(x => x.FirstName.ToLower().Contains(searchStr)
                        || x.LastName.ToLower().Contains(searchStr)
                        || x.Birthday.ToString().Contains(searchStr));
            CollectionView.MoveCurrentTo(n);

        }

        private void tbx_View_Student_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchStr = tbx_View_Student_search.Text.ToLower();
            var list = CollectionView.Cast<student>();
            student w = list.FirstOrDefault(x =>x.FirstName.ToLower().Contains(searchStr)
                                            ||  x.LastName.ToLower().Contains(searchStr)
                                            ||  x.Birthday.ToString().Contains(searchStr));
            CollectionView.MoveCurrentTo(w);
        }

    



        //private void DG_Student_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    int Hidde_St_ID = Convert.ToInt32(Label_student_ID.Content);
        //    student w = ctx.student.Where(x => x.student_id == Hidde_St_ID).FirstOrDefault();
        //    Student_Information.DataContext = w;


        //    Student_Information.Visibility = Visibility.Visible;
        //    Student_Mang.Visibility = Visibility.Hidden;
        //    Student_Registration.Visibility = Visibility.Hidden;
        //    New_Course.Visibility = Visibility.Hidden;
        //    Mang_Course.Visibility = Visibility.Hidden;
        //    View_Student.Visibility = Visibility.Hidden;
        //    View_Course.Visibility = Visibility.Hidden;
        //}
    }
}
