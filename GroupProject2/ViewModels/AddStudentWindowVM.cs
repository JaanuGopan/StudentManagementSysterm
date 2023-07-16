using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GroupProject2.ViewModels
{
    public partial class AddStudentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public int stuId;
        [ObservableProperty]
        public string? firstName;
        [ObservableProperty]
        public string? lastName;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public string subject1;
        [ObservableProperty]
        public string subject2;
        [ObservableProperty]
        public string subject3;
        [ObservableProperty]
        public string subject4;
        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string title;

        public Action CloseAction { get; internal set; }
        public Student student { get; private set; }

        public AddStudentWindowVM(Student s)
        {
            Student student = s;
            firstName= student.FirstName;
            lastName= student.LastName;
            age= student.Age;
            subject1 = student.Subject1;
            subject2 = student.Subject2;
            subject3 = student.Subject3;
            subject4 = student.Subject4;
            gpa = student.GPA;

        }
        public AddStudentWindowVM() { }

        [RelayCommand]
        public void Save()
        {



            if (student == null)
            {

                student = new Student()
                {
                    FirstName= firstName,
                    LastName= lastName,
                    Age= age,
                    Subject1= subject1,
                    Subject2= subject2,
                    Subject3= subject3,
                    Subject4 = subject4,
                    GPA=gpa,
                    Id=stuId


                };


            }
            else
            {

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Subject1 = subject1;
                student.Subject2 = subject2;
                student.Subject3 = subject3;
                student.Subject4 = subject4;
                student.Id = stuId;
                student.GPA= gpa;



            }

            if (student.FirstName != null)
            {

                CloseAction();
            }


            Application.Current.MainWindow.Show();



        }

    }
}
