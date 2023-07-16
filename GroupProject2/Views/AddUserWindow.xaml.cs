using GroupProject2.ViewModels;
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

namespace GroupProject2.Views
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow(AddUserWindowVM vm)
        {

            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }





        private void textUserName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && txtUserName.Text.Length > 0)
            {
                textUserName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUserName.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

       
    }
}
