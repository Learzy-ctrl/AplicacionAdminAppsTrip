using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.Services
{
    public class Conection
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-ecc82-default-rtdb.firebaseio.com/");
    }
}
