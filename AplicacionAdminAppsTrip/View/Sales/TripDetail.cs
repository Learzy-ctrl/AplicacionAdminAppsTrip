using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.Sales
{
    public partial class TripDetail : Form
    {
        public TripDetail()
        {
            InitializeComponent();
        }

        public void GetDataFromSales(TripVM trip)
        {
            txtPointEnd.Text = trip.PointEnd;
            txtPointOrigin.Text = trip.PointOrigin;
            txtStartDate.Text = trip.StartDate;
            txtEndDate.Text = trip.EndDate;
            txtStartDateTime.Text = trip.StartDateTime;
            txtEndDateTime.Text = trip.EndDateTime;
            txtRoundTrip.Text = trip.RoundTrip;
            txtNumberPassangers.Text = trip.NumberPassangers;
            txtNameUser.Text = trip.NameUser;
            txtPhoneNumber.Text = trip.PhoneNumber;
            txtFeedBack.Text = trip.FeedBack;
        }
    }
}
