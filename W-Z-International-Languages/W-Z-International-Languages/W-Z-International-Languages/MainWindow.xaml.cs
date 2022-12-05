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

namespace W_Z_International_Languages
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Home home = new Home();
        public MainWindow()
        {

            InitializeComponent();
        }



        private void LOGIN()
        {
            if (UserName.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password");
                UserName.Text = "";
                Pass.Text = "";
            }

            else 
            {
               
                    using (W_Z_International_Languag db = new W_Z_International_Languag())    //Verbindung zur Datenbank wird aufgebaut und  neuen DBContext Angelegt. 
                    {
                        var list = db.student.Where(x => x.Username == UserName.Text && x.Password == Pass.Text).ToList();// Zugriff auf ("UserName","Passwort")Spalten in "Benutzer" Tabell. 
                        foreach (var b in list)
                        {
                            home.Show();
                                Close();
                                return;
                        }



                        MessageBox.Show("username or password is incorrect!");
                        UserName.Text = "";
                        Pass.Text = "";


                    }
               


            }

            }
            private void UserName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "User Name")
            {
                UserName.Text = "";
            }
        }

        private void Pass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Pass.Text == "Pass Word")
            {
                Pass.Text = "";
            }
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            LOGIN();

          
        }
        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)     //wenn User Enter auf Tastatur tippt  ==>Login
            {
                LOGIN();
            }
            else if (e.Key == Key.Delete) //wenn User Delete auf Tastatur tippt  ==> Username und Passwot von Textbox löschen
            {
                UserName.Text = "";
                Pass.Text = "";
            }
        }
    }
}
