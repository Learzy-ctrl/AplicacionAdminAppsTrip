using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using Firebase.Database.Query;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.Controller
{
    public class LoginController
    {
        public async Task<CredentialsVM> AuthenticationAsync(CredentialsVM usercredential)
        {
            try
            {
                var auth = new UserRepository();
                var Id = await auth.SignIn(usercredential.Email, usercredential.Password);
                if(Id != null)
                {
                    var user = await Conection.firebase.Child("LocalUsers").Child(Conection.UserId).OnceSingleAsync<UserVM>();
                    usercredential.IdAccess = user.Rol;
                    return usercredential;
                }
                else
                {
                    usercredential.Email = "Not Found";
                    return usercredential;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                usercredential.Email = "Error";
                return usercredential;
            }
        }


    }
}
