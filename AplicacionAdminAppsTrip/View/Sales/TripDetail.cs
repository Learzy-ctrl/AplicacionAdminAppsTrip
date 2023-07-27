using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using FirebaseAdmin.Messaging;
using System;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.Sales
{
    public partial class TripDetail : Form
    {
        TripVM tripVM = new TripVM();
        Sales salesform = new Sales();
        DeclinedServices declinedServices = new DeclinedServices();
        private readonly SalesController salesController = null;
        public TripDetail(TripVM trip, Sales form, DeclinedServices declined)
        {
            InitializeComponent();
            GetDataFromSales(trip);
            salesController = new SalesController();
            declinedServices = declined;
            salesform = form;
            tripVM = trip;
            LoadingGif.Hide();
        }

        public void GetDataFromSales(TripVM trip)
        {
            txtPointEnd.Text = trip.EndPoint;
            txtPointOrigin.Text = trip.PointOrigin;
            txtStartDate.Text = trip.StartDate;
            txtEndDate.Text = trip.EndDate;
            txtStartDateTime.Text = trip.StartDateTime;
            txtEndDateTime.Text = trip.BackDateTime;
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
            if(trip.TotalPrice != null)
            {
                if (trip.SecondOption == "true")
                {
                    txtpricerejected.Visible = true;
                    txtpricerejected.Text = trip.TotalPrice;
                    rejectedlbl.Visible = true;
                    txtPrice.ReadOnly = false;
                    SendQuotebtn.Visible = true;
                }
                else
                {
                    txtPrice.Text = trip.TotalPrice;
                    txtPrice.ReadOnly = true;
                    SendQuotebtn.Visible = false;
                }
            }
        }

        private async void SendQuotebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                LoadingGif.Show();
                tripVM.TotalPrice = txtPrice.Text;
                bool IsValid;
                if(tripVM.SecondOption == "true")
                {
                    IsValid = await salesController.DeleteRejectedTrip(tripVM.UserId, tripVM.Key);
                    await declinedServices.RefreshTable();
                }
                else
                {
                    IsValid = await salesController.DeletePendingQuote(tripVM.UserId, tripVM.Key);
                    await salesform.RefreshCountButtons();
                    await salesform.RefreshTable();
                }
                if (IsValid)
                {
                    await salesController.SendPendingQuote(tripVM);
                    SendNotification(tripVM.EndPoint, tripVM.IdDevice);
                    LoadingGif.Hide();
                    MessageBox.Show("Se ha enviado Correctamente", "Exito");
                    this.Close();
                }
                else
                {
                    LoadingGif.Hide();
                    MessageBox.Show("Ocurrio un error, Intenta de nuevo", "Error");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ingresa el precio", "Alerta");
            }
        }

        public void SendNotification(string EndPoint, string IdDevice)
        {
            var messaging = FirebaseMessaging.GetMessaging(Conection.app);
            var message = new FirebaseAdmin.Messaging.Message()
            {
                Token = IdDevice,
                Notification = new Notification()
                {
                    Title = "Tienes Nuevas Cotizaciones",
                    Body = "Se realizo cotizacion de tu viaje a: " + EndPoint
                }
            };
            messaging.SendAsync(message).GetAwaiter().GetResult();
        }
    }
}
