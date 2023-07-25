using Firebase.Database;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.Services
{
    public class Conection
    {
        public static string Token { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string UserId { get; set; }

        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-ecc82-default-rtdb.firebaseio.com/",
        new FirebaseOptions
        {
            AuthTokenAsyncFactory = () => RefreshToken()
        });

        public static async Task<string> RefreshToken()
        {
            if (JwtHelper.DecodeJWT(Token))
            {
                return Token;
            }
            else
            {
                var auth = new UserRepository();
                var response = await auth.SignIn(Email, Password);
                return response;
            }
        }


        public static FirebaseApp app = FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.FromFile("Key.json")
        });
    }

    public class JwtHelper
    {
        public static bool DecodeJWT(string token)
        {
            DateTime date = DateTime.Now;
            var handler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtDecoded;

            try
            {
                jwtDecoded = handler.ReadJwtToken(token);
            }
            catch (Exception)
            {
                return false;
            }

            foreach (var claim in jwtDecoded.Claims)
            {
                if (claim.Type == "exp")
                {
                    var timestamp = int.Parse(claim.Value);
                    date = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime.ToLocalTime();
                }
            }

            if (date > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
