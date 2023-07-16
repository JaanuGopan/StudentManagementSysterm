using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject2.Models;
using GroupProject2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GroupProject2.ViewModels
{
    public partial class AdminWindowVM : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<User> userlist;

        [ObservableProperty]
        public User selecteduser = null;

        public bool successlogin;


        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [RelayCommand]
        public void AddUser()
        {
            var vm = new AddUserWindowVM();
            vm.title = "ADD USER";
            AddUserWindow window = new AddUserWindow(vm);
            window.ShowDialog();

            if (vm.user.UserName == null || vm.user.Password == null)
            {
                MessageBox.Show("Please Enter The Details..", "Warning!");
            }
            else
            {
                User u = new User()
                {
                    UserName = vm.user.UserName,
                    Password = vm.user.Password,
                    IsAdmin = false
                };
                using (var db = new DataContext())
                {
                    db.UsersDb.Add(u);
                    db.SaveChanges();
                }
                
            }
            LoadUser();
        }





        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void LoadUser()
        {
            using (var db = new DataContext())
            {
                var list = db.UsersDb.OrderBy(u => u.UserId);
                Userlist = new ObservableCollection<User>(list);
            }

        }



        [RelayCommand]
        public void DeleteUser()
        {
            if(Selecteduser!=null)
            {
                using (var db = new DataContext())
                {
                    db.UsersDb.Remove(Selecteduser);
                    db.SaveChanges();
                }
            }
            
            LoadUser();
        }



        [RelayCommand]
        public void EditUser()
        {
            User us = Selecteduser;
            if (us != null)
            {
                var vm = new AddUserWindowVM(us);
                vm.title = "EDIT USER";
                var window = new AddUserWindow(vm);

                window.ShowDialog();

                using (var db = new DataContext())
                {
                    
                    db.UsersDb.Remove(us);
                    vm.user.UserId = us.UserId;
                    db.UsersDb.Add(vm.user);
                    db.SaveChanges();
                }



            }
            else
            {
                MessageBox.Show("Please Select the user", "Warning!");
            }
            LoadUser();
        }

        
        
        public  AdminWindowVM() 
        {
            LoadUser();
        }




    }
}
