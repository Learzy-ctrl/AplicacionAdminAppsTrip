using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using FirebaseAdmin.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.TripAssignment
{
    public partial class TravelDetail : Form
    {
        private readonly TripAssignamentController controller = null;
        private readonly UserManagmentController controllerUser = null;
        string keyUser;
        string Key;
        Assignment form;
        public TravelDetail(AssignamentVM travel, bool flag ,Assignment form)
        {
            InitializeComponent();
            LoadingGif.Visible = false;
            controller = new TripAssignamentController();
            controllerUser = new UserManagmentController();
            keyUser = travel.UserKey;
            Key = travel.Key;
            this.form = form;
            SetDataToForm(travel, flag);
        }

        public void SetDataToForm(AssignamentVM travel, bool flag)
        {
            txtTravelTo.Text = travel.EndPoint;
            txtDate.Text = travel.StartDate;
            txtDatetime.Text = travel.StartDatetime;
            txtPointOfOrigin.Text = travel.PointOrigin;
            txtName.Text = travel.UserName;
            txtPhoneNumber.Text = travel.PhoneNumber;
            txtOperator.Text = travel.Operator;
            txtPayWay.Text = travel.PayWay;
            txtTotal.Text = travel.Total;
        }

        private async void btnSendAssignament_Click(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;
            await Task.Delay(500);
            var user = await controllerUser.GetUserAsync(keyUser);
            if(user != null)
            {
                SendNotification(txtTravelTo.Text, user.IdDevice);
                LoadingGif.Visible = false;
                MessageBox.Show("Se ha reenviado asignacion", "Asignacion reenviada");
                this.Close();
            }
            else
            {
                LoadingGif.Visible = false;
                MessageBox.Show("Ha ocurrido un error", "Error al reenviar");
            }
            
            
        }
        private async void BtnCancelled_Click(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;
            await Task.Delay(500);
            var IsValid = await controller.DeleteAssignamentAsync(keyUser, Key);
            LoadingGif.Visible = false;
            if (IsValid)
            {
                form.RefreshDontConfirmTable();
                MessageBox.Show("Se ha cancelado asignacion", "Asignacion cancelada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error al cancelar");
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
                    Title = "Nueva asignacion pendiente",
                    Body = "Se te ha asignado un viaje a: " + EndPoint
                }
            };
            messaging.SendAsync(message).GetAwaiter().GetResult();
        }
    }
}
