using Firebase.Database;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace AplicacionAdminAppsTrip.Services
{
    public class Conection
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-ecc82-default-rtdb.firebaseio.com/");

        public static FirebaseApp app = FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.FromFile("Key.json")
        });
    }
}
