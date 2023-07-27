using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using Firebase.Database.Query;
using FirebaseAdmin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var user = await Conection.firebase.Child("LocalUser").Child(id).OnceSingleAsync<UserVM>();
                return user;
            }
            catch
            {
                return null;
            }
        }
    }
}
