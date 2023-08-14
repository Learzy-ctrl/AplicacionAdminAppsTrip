using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.View.TripAssignment;
using AplicacionAdminAppsTrip.ViewModel;
using Firebase.Database.Query;
using FirebaseAdmin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

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

        public async Task<List<TripVM>> GetPendingsAssignamentsForDate(string date)
        {
            try
            {
                var triplist = new List<TripVM>();
                var list = await Conection.firebase.Child("PendingAssignments").OnceAsync<TripVM>();
                foreach(var l in list)
                {
                    triplist.Add(l.Object);
                }
                return triplist.Where(l => l.StartDate == date).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<TripVM> GetPendingAssignament(string id)
        {
            try
            {
                var trip = await Conection.firebase.Child("PendingAssignments").Child(id).OnceSingleAsync<TripVM>();
                return trip;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UserVM>> GetAllOperators()
        {
            try
            {
                var Operators = new List<UserVM>();
                var list = await Conection.firebase.Child("LocalUsers").OnceAsync<UserVM>();
                foreach(var l in list)
                {
                    Operators.Add(l.Object);
                }
                return Operators.Where(o => o.Rol == "3").ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserVM> GetOperatorDataAsync(string id)
        {
            try
            {
                var user = await Conection.firebase.Child("LocalUsers").Child(id).OnceSingleAsync<UserVM>();
                return user;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> PostAssignamentAsync(AssignamentVM assignament, string key)
        {
            try
            {
                var response = await Conection.firebase.Child("AssignedTrips").Child(assignament.UserKey).PostAsync(assignament);
                assignament.Key = response.Key;
                await Conection.firebase.Child("AssignedTrips").Child(assignament.UserKey).Child(response.Key).PutAsync(assignament);
                await Conection.firebase.Child("PendingAssignments").Child(key).DeleteAsync();
                return true;
            }
            catch(Exception e)
            {
                if(e.Message.Contains("Url: Couldn't build the url"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<List<AssignamentVM>> GetAllTravelsPendingAsync(string date)
        {
            try
            {
                var travelList = await Conection.firebase.Child("AssignedTrips").OnceAsync<AssignamentVM>();
                var listOfList = new List<List<AssignamentVM>>();
                foreach(var t in travelList)
                {
                    var listTravel = new List<AssignamentVM>();
                    var list2 = await Conection.firebase.Child("AssignedTrips").Child(t.Key).OnceAsync<AssignamentVM>();
                    foreach(var l in list2)
                    {
                        listTravel.Add(l.Object);
                    }
                    listOfList.Add(listTravel);
                }

                var list = new List<AssignamentVM>();

                foreach(var l in listOfList)
                {
                    foreach(var t in l)
                    {
                        list.Add(t);
                    }
                }
                if(date == null)
                {
                    return list;
                }
                else
                {
                    return list.Where(l => l.StartDate == date).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<AssignamentVM>> GetAllConfirmsTravelsAsync(string date)
        {
            try
            {
                var travelList = await Conection.firebase.Child("ConfirmedAssignments").OnceAsync<AssignamentVM>();
                var listOfList = new List<List<AssignamentVM>>();
                foreach (var t in travelList)
                {
                    var listTravel = new List<AssignamentVM>();
                    var list2 = await Conection.firebase.Child("ConfirmedAssignments").Child(t.Key).OnceAsync<AssignamentVM>();
                    foreach (var l in list2)
                    {
                        listTravel.Add(l.Object);
                    }
                    listOfList.Add(listTravel);
                }

                var list = new List<AssignamentVM>();

                foreach (var l in listOfList)
                {
                    foreach (var t in l)
                    {
                        list.Add(t);
                    }
                }
                if (date == null)
                {
                    return list;
                }
                else
                {
                    return list.Where(l => l.StartDate == date).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<AssignamentVM> GetTravelPendingDetail(string id, string key)
        {
            try
            {
                var travel = await Conection.firebase.Child("AssignedTrips").Child(id).Child(key).OnceSingleAsync<AssignamentVM>();
                return travel;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public async Task<AssignamentVM> GetTravelConfirmDetail(string id, string key)
        {
            try
            {
                var travel = await Conection.firebase.Child("ConfirmedAssignments").Child(id).Child(key).OnceSingleAsync<AssignamentVM>();
                return travel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> DeleteAssignamentAsync(string id, string key)
        {
            try
            {
                await Conection.firebase.Child("AssignedTrips").Child(id).Child(key).DeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
