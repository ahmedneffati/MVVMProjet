using MVVMProjet.Models;
using MVVMProjet.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProjet.Services
{
   public class UserServices
    {
        RestClient<User> restClient = new RestClient<User>("http://localhost:49421/api/admins/");
        public async Task<List<User>> getUsersAsync ()
        {
           
            
            var users = await restClient.GetAsync();
            return users;

        }
    
   
        public async Task PostUsersAsync(User e)
        {
          
            var users = await restClient.PostAsync(e);
           

        }
        public async Task PutUsersAsync(int id,User e)
        {
         
            var users = await restClient.PutAsync(id,e);


        }
        public async Task DeleteUsersAsync(int id)
        {
           
            var users = await restClient.DeleteAsync(id);


        }

    }

    }