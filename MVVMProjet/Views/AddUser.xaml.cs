using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMProjet.ViewModels;
using Xamarin.Forms;

namespace MVVMProjet.Views
{
    public partial class AddUser : ContentPage
    { 
        

        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(UserViewModel userViewModel)
        {
            InitializeComponent();
            BindingContext= userViewModel;
        }
    }
}
