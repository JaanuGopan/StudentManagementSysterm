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
    public partial class StudentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> studentlist;

        [ObservableProperty]
        public Student selectedstudent = null;





        // Calculate the GPA based on the grade values
        public double CalculateGPA(Student s)
        {
            return (Subject_GPA(s.Subject1) + Subject_GPA(s.Subject2) + Subject_GPA(s.Subject3) + Subject_GPA(s.Subject4)) / 4;
        }

        public double Subject_GPA(string grade)
        {
            switch (grade)
            {
                case "A+":
                    return 4.000;
                case "A":
                    return 4.000;
                case "A-":
                    return 3.700;
                case "B+":
                    return 3.300;
                case "B":
                    return 3.000;
                case "B-":
                    return 2.700;
                case "C+":
                    return 2.300;
                case "C":
                    return 2.000;
                case "C-":
                    return 1.700;
                case "F":
                    return 0.000;
                default:
                    return 0.000;
            }
        }





        [RelayCommand]
        public void AddSudent()
        {
            var vm = new AddStudentWindowVM();
            vm.title = "ADD Student";
            AddStudentWindow window = new AddStudentWindow(vm);
            window.ShowDialog();

            if (vm.student.FirstName == null)
            {
                MessageBox.Show("Please Enter The Details..", "Warning!");
            }
            else
            {
                Student st = new Student()
                {
                    FirstName= vm.student.FirstName,
                    LastName= vm.student.LastName,
                    Age= vm.student.Age,
                    GPA= CalculateGPA(vm.student),
                    Subject1= vm.student.Subject1,
                    Subject2= vm.student.Subject2,
                    Subject3= vm.student.Subject3,
                    Subject4= vm.student.Subject4,
                    Id= vm.student.Id
                };
                using (var db = new DataContext())
                {
                    db.StudentDb.Add(st);
                    db.SaveChanges();
                }

            }
            LoadStudent();
        }


        [RelayCommand]
        public void DeleteStudent()
        {
            if (Selectedstudent != null)
            {
                using (var db = new DataContext())
                {
                    db.StudentDb.Remove(Selectedstudent);
                    db.SaveChanges();
                }
            }

            LoadStudent();
        }

        [RelayCommand]
        public void EditStudent()
        {
            
            if (Selectedstudent != null)
            {
                var vm = new AddStudentWindowVM(Selectedstudent);
                vm.title = "Edit Student";
                var window = new AddStudentWindow(vm);

                window.ShowDialog();

                using (var db = new DataContext())
                {

                    db.StudentDb.Remove(Selectedstudent);
                    vm.student.Id = Selectedstudent.Id;
                    db.StudentDb.Add(vm.student);
                    db.SaveChanges();
                }



            }
            else
            {
                MessageBox.Show("Please Select the Student", "Warning!");
            }
            LoadStudent();
        }


        public void LoadStudent()
        {
            using (var db = new DataContext())
            {
                var list = db.StudentDb.OrderBy(s => s.Id);
                Studentlist = new ObservableCollection<Student>(list);
            }
        }
        public StudentWindowVM()
        {
            LoadStudent();
        }

        


    }
}
