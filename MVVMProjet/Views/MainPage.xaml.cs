using MVVMProjet.Models;
using MVVMProjet.ViewModels;
using MVVMProjet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMProjet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           // BindingContext = new UserViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUser());
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           var user= userlist.SelectedItem as User;
            if (user != null)
            {
                var userViewModel = BindingContext as UserViewModel;
                if (userViewModel != null)
                {
                    userViewModel.UsersAdd = user;
                    await Navigation.PushAsync(new AddUser( userViewModel));
                }
            }

        }
    }
}
