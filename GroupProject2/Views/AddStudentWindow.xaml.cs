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
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow(AddStudentWindowVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }

       

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void textFirstName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtFirstName.Focus();
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && txtFirstName.Text.Length > 0)
            {
                textFirstName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textFirstName.Visibility = Visibility.Visible;
            }
        }

        private void textLastName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLastName.Focus();
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text) && txtLastName.Text.Length > 0)
            {
                textLastName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textLastName.Visibility = Visibility.Visible;
            }
        }

        private void textAge_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtAge.Focus();
        }

        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAge.Text) && txtAge.Text.Length > 0)
            {
                textAge.Visibility = Visibility.Collapsed;
            }
            else
            {
                textAge.Visibility = Visibility.Visible;
            }
        }



        private void textSubject1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSubject1.Focus();
        }

        private void txtSubject1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject1.Text) && txtSubject1.Text.Length > 0)
            {
                textSubject1.Visibility = Visibility.Collapsed;
            }
            else
            {
                textSubject1.Visibility = Visibility.Visible;
            }
        }

        private void textSubject2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSubject2.Focus();
        }

        private void txtSubject2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject2.Text) && txtSubject2.Text.Length > 0)
            {
                textSubject2.Visibility = Visibility.Collapsed;
            }
            else
            {
                textSubject2.Visibility = Visibility.Visible;
            }
        }

        private void textSubject3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSubject3.Focus();
        }

        private void txtSubject3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject3.Text) && txtSubject3.Text.Length > 0)
            {
                textSubject3.Visibility = Visibility.Collapsed;
            }
            else
            {
                textSubject3.Visibility = Visibility.Visible;
            }
        }

        private void textSubject4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtSubject4.Focus();
        }

        private void txtSubject4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject4.Text) && txtSubject4.Text.Length > 0)
            {
                textSubject4.Visibility = Visibility.Collapsed;
            }
            else
            {
                textSubject4.Visibility = Visibility.Visible;
            }
        }
    }
}
