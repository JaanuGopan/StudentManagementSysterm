using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject2.Migrations;
using GroupProject2.Models;
using GroupProject2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GroupProject2.ViewModels
{
    public partial class AddUserWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string? userName;
        [ObservableProperty]
        public string? password;
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public bool isAdmin;

        [ObservableProperty]
        public string title;

        

        public User user { get; private set; }
        public Action CloseAction { get; internal set; }
        public AddUserWindowVM(User u) 
        {
            User user= u;
            userName = user.UserName;
            password=user.Password;
            id=user.UserId;
            isAdmin=user.IsAdmin;
        }

        public AddUserWindowVM() { }

        

        [RelayCommand]
        public void Save()
        {


          
            if (user == null)
            {

                user = new User()
                {
                    UserId= id,
                    UserName = userName,
                    Password= password
                    

                };


            }
            else
            {

                user.UserId = id;
                user.UserName = userName;
                user.Password = password;



            }

            if (user.UserName != null)
            {

                CloseAction();
            }

            
            Application.Current.MainWindow.Show();
            
            

        }

        [RelayCommand]
        public void CloseButtonFunc()
        {
            //LoadUser();
            CloseAction();
            Application.Current.MainWindow.Show();
        }



    }
}
