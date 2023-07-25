using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.Controller
{
    public class TripAssignamentController
    {
        public async Task<List<TripVM>> GetAllPendingAssignments()
        {
            try
            {
                var tripList = new List<TripVM>();
                var list = await Conection.firebase.Child("PendingAssignments").OnceAsync<TripVM>();
                foreach(var l in list)
                {
                    tripList.Add(l.Object);
                }
                return tripList;
            }
            catch
            {
                return null;
            }
        }
    }
}
