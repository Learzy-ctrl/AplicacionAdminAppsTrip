using AplicacionAdminAppsTrip.Controller;
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
        TripVM tripVM = new TripVM();
        private readonly SalesController salesController = null;
        public TripDetail(TripVM trip)
        {
            InitializeComponent();
            GetDataFromSales(trip);
            salesController = new SalesController();
            tripVM = trip;
        }

        public void GetDataFromSales(TripVM trip)
        {
            txtPointEnd.Text = trip.EndPoint;
            txtPointOrigin.Text = trip.PointOrigin;
            txtStartDate.Text = trip.StartDate;
            txtEndDate.Text = trip.EndDate;
            txtStartDateTime.Text = trip.StartDateTime;
            if (string.IsNullOrEmpty(trip.BackDateTime))
            {
                txtEndDateTime.Text = "Sin Hora Retorno";
            }
            else
            {
                txtEndDateTime.Text = trip.BackDateTime;
            }
            txtRoundTrip.Text = trip.Rounded;
            txtNumberPassangers.Text = trip.NumberPassengers;
            txtNameUser.Text = trip.Name;
            txtPhoneNumber.Text = trip.PhoneNumber;
            if (string.IsNullOrEmpty(trip.FeedBack))
            {
                txtFeedBack.Text = "Sin Comentarios";
            }
            else
            {
                txtFeedBack.Text = trip.FeedBack;
            }
            if (string.IsNullOrEmpty(trip.OptionQuote))
            {
                txtService.Text = "Principal";
            }
            else
            {
                txtService.Text = trip.OptionQuote;
            }

        }

        private async void SendQuotebtn_Click(object sender, EventArgs e)
        {
            tripVM.TotalPrice = txtPrice.Text;
            await salesController.DeletePendingQuote(tripVM.UserId, tripVM.Key);
            await salesController.SendPendingQuote(tripVM);
            MessageBox.Show("Se ha enviado Correctamente", "Exito");
            this.Close();
        }
    }
}
