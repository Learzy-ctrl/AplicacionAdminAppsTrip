using AplicacionAdminAppsTrip.Model;
using Firebase.Auth;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AplicacionAdminAppsTrip.Services
{
    public class UserRepository
    {
        static string WebAPIkey = "AIzaSyAN9MIGaBRpm7E_8ImP6uEGpkQomJkjfhg";
        FirebaseAuthProvider authProvider;

        public UserRepository()
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
        }

        public async Task<bool> ChangeEmail(string newEmail, string oldEmail, string password)
        {
            try
            {
                var token = await authProvider.SignInWithEmailAndPasswordAsync(oldEmail, password);
                await authProvider.ChangeUserEmail(token.FirebaseToken, newEmail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ChangePassword(string NewPassword, string Email, string OldPassword)
        {
            try
            {
                var token = await authProvider.SignInWithEmailAndPasswordAsync(Email, OldPassword);
                await authProvider.ChangeUserPassword(token.FirebaseToken, NewPassword);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task ChangeEmailAndPasswordAsync(string newEmail, string NewPassword, string OldEmail, string OldPassword)
        {
            try
            {
                var token = await authProvider.SignInWithEmailAndPasswordAsync(OldEmail, OldPassword);
                await authProvider.ChangeUserEmail(token.FirebaseToken, newEmail);
                var newtoken = await authProvider.SignInWithEmailAndPasswordAsync(newEmail, OldPassword);
                await authProvider.ChangeUserPassword(newtoken.FirebaseToken, NewPassword);
            }
            catch
            {
            }
        }

        public async Task<bool> Deleteuser(string key)
        {
            try
            {
                var user = await Conection.firebase.Child("LocalUsers").Child(key).OnceSingleAsync<UserVM>();
                var response = await authProvider.SignInWithEmailAndPasswordAsync(user.Email, user.Password);
                await authProvider.DeleteUserAsync(response.FirebaseToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<string> SignIn(string email, string password)
        {
            try
            {
                var response = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                Conection.Token = response.FirebaseToken;
                Conection.UserId = response.User.LocalId;
                return response.FirebaseToken; 
            }
            catch
            {
                return null;
            }
        }

        public async Task<string>Register(string email, string password)
        {
            try
            {
                var response = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                return response.User.LocalId;
            }
            catch
            {
                return null;
            }
        }
    }
}
