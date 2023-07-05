using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.Controller
{
    public class LoginController
    {
        public async Task<CredentialsVM> AuthenticationAsync(CredentialsVM usercredential)
        {
            try
            {
                var ListOfUsers = new List<UserVM>();
                var list = await Conection.firebase.Child("LocalUsers").OnceAsync<UserVM>();
                foreach (var l in list)
                {
                    ListOfUsers.Add(l.Object);
                }
                var User = ListOfUsers.FirstOrDefault(l => l.Name.ToLower() == usercredential.Name.ToLower());
                if (User != null)
                {
                    if(User.Password == usercredential.Password)
                    {
                        usercredential.IdAccess = User.Rol;
                        usercredential.Name = User.Name;
                        return usercredential;
                    }
                    else
                    {
                        usercredential.Name = "NotFound";
                        return usercredential;
                    }
                }
                else
                {
                    usercredential.Name = "NotFound";
                    return usercredential;
                }
            }
            catch
            {
                usercredential.Name = "Error";
                return usercredential;
            }
        }


    }
}
