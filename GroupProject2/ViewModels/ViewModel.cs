using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject2.ViewModels
{
    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty] public string? firstname;
        [ObservableProperty] public string? lastname;
        [ObservableProperty] public string? username;
        [ObservableProperty] public string? password;
        [ObservableProperty] public string? adminusername;
        [ObservableProperty] public string? adminpassword;

        public ViewModel() 
        {
            using (var context = new DataContext()) 
            {

            }
        }
    }
}
