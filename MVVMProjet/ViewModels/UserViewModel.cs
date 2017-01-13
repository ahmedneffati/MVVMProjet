using MVVMProjet.Models;
using MVVMProjet.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMProjet.ViewModels
{
   public class UserViewModel: INotifyPropertyChanged
    {
        private List<User> _UsersList;
        public List<User> UsersList
        {
            get
            {
                return _UsersList;
            }
            set
            {
                _UsersList = value;
                OnPropertyChanged();
            }
        }
        private User _UsersAdd=new User() ;
        public User UsersAdd
        {
            get
            {
                return _UsersAdd;
            }
            set
            {
                _UsersAdd = value;
                OnPropertyChanged();
            }
        }
        public Command PostCommand
        {
            get
            {

                return new Command(async () =>
                {
                    var u = new UserServices(); 
                    await u.PostUsersAsync(_UsersAdd);
                });
            }
        }
        public UserViewModel()
        {
            InitializerDataASYNC();
        }
        
        private async Task InitializerDataASYNC()
        {
            var UsersServ = new UserServices();
            UsersList = await UsersServ.getUsersAsync();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public Command PutCommand
        {
            get
            {

                return new Command(async () =>
                {
                    var u = new UserServices();
                    await u.PutUsersAsync(_UsersAdd.ID,_UsersAdd);
                });
            }
        }
        public Command DeletetCommand
        {
            get
            {

                return new Command(async () =>
                {
                    var u = new UserServices();
                    await u.DeleteUsersAsync(_UsersAdd.ID);
                });
            }
        }
        
    }
}
