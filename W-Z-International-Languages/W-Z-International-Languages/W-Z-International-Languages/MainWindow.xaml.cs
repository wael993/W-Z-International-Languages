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
        public MainWindow()
        {
            InitializeComponent();
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

        }
    }
}
