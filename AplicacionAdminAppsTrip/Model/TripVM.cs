using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAdminAppsTrip.ViewModel
{
    public class TripVM
    {
        public string UserId { get; set; }
        public string Key { get; set; }
        public string PointOrigin { get; set; }
        public string EndPoint { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FeedBack { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StartDateTime { get; set; }
        public string BackDateTime { get; set; }
        public string Rounded { get; set; }
        public string NumberPassengers { get; set; }
        public string OptionQuote { get; set; }
        public string TotalPrice { get; set;}
        public string QuoteDateSent { get; set; }
        public string QuoteDateConfirmed { get; set; }
        public string QuoteDateRejected { get; set; }
        public string CancelledTravelDate { get; set; }
        public string SecondOption { get; set; }
        public string IdDevice { get; set; }

    }
}
