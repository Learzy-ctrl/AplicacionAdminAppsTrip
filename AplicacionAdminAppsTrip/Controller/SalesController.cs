using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.Controller
{
    
    public class SalesController
    {
        public async Task<List<List<TripVM>>> GetAllQuotes()
        {
            List<List<TripVM>> tripVMs = new List<List<TripVM>>();
            var ListofList = await Conection.firebase.Child("OutstandingTravelFees").OnceAsync<TripVM>();
            foreach(var l in ListofList)
            {
                List<TripVM> trips = new List<TripVM>();
                var List = await Conection.firebase.Child("OutstandingTravelFees").Child(l.Key).OnceAsync<TripVM>();
                foreach(var li in List)
                {
                    TripVM trip = new TripVM();
                    trip = li.Object;
                    trips.Add(trip);
                }
                tripVMs.Add(trips);
            }
            return tripVMs;
        }

        public async Task<TripVM> GetTripDetail(string key, string Id)
        {
            var TripDetail = await Conection.firebase.Child("OutstandingTravelFees").Child(Id).Child(key).OnceSingleAsync<TripVM>();
            return TripDetail;
        }

        public async Task DeletePendingQuote(string Id, string key)
        {
                await Conection.firebase.Child("OutstandingTravelFees").Child(Id).Child(key).DeleteAsync();
        }

        public async Task<bool> SendPendingQuote(TripVM trip)
        {
            try
            {
                var response = await Conection.firebase.Child("QuotesMade").Child(trip.UserId).PostAsync(trip);
                trip.Key = response.Key;
                await Conection.firebase.Child("QuotesMade").Child(trip.UserId).Child(response.Key).PutAsync(trip);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
