using GroupProject2.Models;
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
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
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


        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
        private void Button_Click_LogIn(object sender, RoutedEventArgs e)
        {
            using(var db = new DataContext())
            {
                var user = db.UsersDb;
                string login = "Wrong";

                foreach (var std in user)
                {
                    if (txtUserName.Text.ToString() == std.UserName && txtPassword.Password.ToString() == std.Password && std.IsAdmin==true)
                    {
                        login = "admin";
  
                    }
                    else if(txtUserName.Text.ToString() == std.UserName && txtPassword.Password.ToString() == std.Password && std.IsAdmin ==false)
                    {
                        login= "normal";
                    }
      
                }
                if(login=="admin")
                {
                    var window = new AdminWindow();
                    window.Show();
                    Close();
                }
                else if(login=="normal")
                {
                    var window = new StudentWindow();
                    window.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Passward");
                }
                

            }
            
            //else if()
        }
    }
}
