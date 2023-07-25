using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.Controller
{
    public class UserManagmentController
    {
        public async Task<bool> PostNewUserAsync(UserVM user)
        {
            try
            {
                await Conection.firebase.Child("LocalUsers").Child(user.IdUser).PutAsync(user);
                var Rol = new Dictionary<string, string>
                {
                    { user.IdUser, user.IdUser}
                };
                await Conection.firebase.Child("Rol").Child(user.IdUser).PutAsync(Rol);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public async Task<List<UserVM>> GetUsersAsync()
        {
            try
            {
                var List = new List<UserVM>(); 
                var ListOfUsers = await Conection.firebase.Child("LocalUsers").OnceAsync<UserVM>();
                foreach(var l in ListOfUsers)
                {
                    List.Add(l.Object);
                }
                return List;
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserVM> GetUserAsync(string key)
        {
            try
            {
                var user = await Conection.firebase.Child("LocalUsers").Child(key).OnceSingleAsync<UserVM>();
                return user;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> PutUserAsync(UserVM user)
        {
            try
            {
                await Conection.firebase.Child("LocalUsers").Child(user.IdUser).PutAsync(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteUser(string key)
        {
            try
            {
                await Conection.firebase.Child("LocalUsers").Child(key).DeleteAsync();
                await Conection.firebase.Child("Rol").Child(key).DeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
