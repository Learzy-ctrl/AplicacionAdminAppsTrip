using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AplicacionAdminAppsTrip.Controller
{

    public class SalesController
    {
        public async Task<List<List<TripVM>>> GetAllConfirmQuotes()
        {
            try
            {
                List<List<TripVM>> tripVMs = new List<List<TripVM>>();
                var ListofList = await Conection.firebase.Child("ConfirmedTrips").OnceAsync<TripVM>();
                foreach (var l in ListofList)
                {
                    List<TripVM> trips = new List<TripVM>();
                    var List = await Conection.firebase.Child("ConfirmedTrips").Child(l.Key).OnceAsync<TripVM>();
                    foreach (var li in List)
                    {
                        TripVM trip = new TripVM();
                        trip = li.Object;
                        trips.Add(trip);
                    }
                    tripVMs.Add(trips);
                }
                return tripVMs;
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<List<TripVM>>> GetAllQuotes()
        {
            try
            {
                List<List<TripVM>> tripVMs = new List<List<TripVM>>();
                var ListofList = await Conection.firebase.Child("OutstandingTravelFees").OnceAsync<TripVM>();
                foreach (var l in ListofList)
                {
                    List<TripVM> trips = new List<TripVM>();
                    var List = await Conection.firebase.Child("OutstandingTravelFees").Child(l.Key).OnceAsync<TripVM>();
                    foreach (var li in List)
                    {
                        TripVM trip = new TripVM();
                        trip = li.Object;
                        trips.Add(trip);
                    }
                    tripVMs.Add(trips);
                }
                return tripVMs;
            }
            catch
            {
                return null;
            }
        }
        public async Task<TripVM> GetTripDetail(string key, string Id)
        {
            try
            {
                var TripDetail = await Conection.firebase.Child("OutstandingTravelFees").Child(Id).Child(key).OnceSingleAsync<TripVM>();
                return TripDetail;
            }
            catch
            {
                return null;
            }
            
        }
        public async Task<TripVM> GetConfirmTripdetail(string key, string Id)
        {
            try
            {
                var TripDetail = await Conection.firebase.Child("ConfirmedTrips").Child(Id).Child(key).OnceSingleAsync<TripVM>();
                return TripDetail;
            }
            catch
            {
                return null;
            }
            
        }
        public async Task<bool> DeletePendingQuote(string Id, string key)
        {
            try
            {
                var response = await Conection.firebase.Child("OutstandingTravelFees").Child(Id).Child(key).OnceSingleAsync<TripVM>();
                if (response != null)
                {
                    await Conection.firebase.Child("OutstandingTravelFees").Child(Id).Child(key).DeleteAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteRejectedTrip(string Id, string key)
        {
            try
            {
                var response = await Conection.firebase.Child("RejectedTrips").Child(Id).Child(key).OnceSingleAsync<TripVM>();
                if (response != null)
                {
                    await Conection.firebase.Child("RejectedTrips").Child(Id).Child(key).DeleteAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
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

        public async Task<List<TripVM>> GetAllTripRejected()
        {
            try
            {

                List<List<TripVM>> tripVMs = new List<List<TripVM>>();
                List<TripVM> tripList = new List<TripVM>();
                var ListofList = await Conection.firebase.Child("RejectedTrips").OnceAsync<TripVM>();
                foreach (var l in ListofList)
                {
                    List<TripVM> trips = new List<TripVM>();
                    var List = await Conection.firebase.Child("RejectedTrips").Child(l.Key).OnceAsync<TripVM>();
                    foreach (var li in List)
                    {
                        TripVM trip = new TripVM();
                        trip = li.Object;
                        trips.Add(trip);
                    }
                    tripVMs.Add(trips);
                }
                
                foreach(var t in tripVMs)
                {
                    foreach(var l in t)
                    {
                        tripList.Add(l);
                    }
                }
                return tripList.Where(l => l.SecondOption == "true").ToList();
            }
            catch
            {
                return null;
            }
        }
        public async Task<TripVM> GetTripRejectedDetail(string key, string userid)
        {
            try
            {
                var TripRejected = await Conection.firebase.Child("RejectedTrips").Child(userid).Child(key).OnceSingleAsync<TripVM>();
                return TripRejected;
            }
            catch
            {
                return null;
            }
        }


    }
}
