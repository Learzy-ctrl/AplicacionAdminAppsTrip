using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using FirebaseAdmin.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.TripAssignment
{
    public partial class AssignamentDetail : Form
    {
        private readonly TripAssignamentController controller = null;
        string keyAssignmentPending;
        Assignment formAssignent;
        public AssignamentDetail(TripVM pending, Assignment form)
        {
            InitializeComponent();
            LoadingGif.Visible = false;
            formAssignent = form;
            controller = new TripAssignamentController();
            if (pending != null)
            {
                keyAssignmentPending = pending.Key;
            }
            PrintData(pending);
            PrintComboBox();
        }

        public void PrintData(TripVM trip)
        {
            if (trip != null)
            {
                txtTravelTo.Text = trip.EndPoint;
                txtDate.Text = trip.StartDate;
                txtDatetime.Text = trip.StartDateTime;
                txtPointOfOrigin.Text = trip.PointOrigin;
                txtPhoneNumber.Text = trip.PhoneNumber;
                txtName.Text = trip.Name;
                txtQuotePrice.Text = trip.TotalPrice;

                txtTravelTo.Enabled = false;
                txtDate.Enabled = false;
                txtDatetime.Enabled = false;
                txtPointOfOrigin.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtName.Enabled = false;
            }
        }

        public async void PrintComboBox()
        {
            var Operators = await controller.GetAllOperators();
            if (Operators != null)
            {
                var list = new List<UserVM>();
                foreach (var o in Operators)
                {
                    var user = new UserVM();
                    user.Name = o.Name + " " + o.LastName;
                    user.IdUser = o.IdUser;
                    list.Add(user);
                }

                CBOperador.DataSource = list;
                CBOperador.ValueMember = "IdUser";
                CBOperador.DisplayMember = "Name";
            }
            else
            {
                CBOperador.Text = "Sin conexion a internet";
            }

            List<ConsultationVM> DataList = new List<ConsultationVM>();
            DataList.Add(new ConsultationVM { Name = "Efectivo", Id = "0" });
            DataList.Add(new ConsultationVM { Name = "Transferencia", Id = "1" });

            CBPay.DataSource = DataList;
            CBPay.ValueMember = "Id";
            CBPay.DisplayMember = "Name";
        }

        private void CBPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = CBPay.SelectedValue.ToString();
            if (id == "1")
            {
                txtTotal.Enabled = false;
                txtTotal.Text = "";
            }
            else
            {
                txtTotal.Enabled = true;
            }
        }

        private async void btnSendAssignament_Click(object sender, EventArgs e)
        {
            var assignament = await GetAssignamentData();
            if (assignament != null)
            {
                LoadingGif.Visible = true;
                await Task.Delay(100);
                var IsValid = await controller.PostAssignamentAsync(assignament, keyAssignmentPending);
                LoadingGif.Visible = false;
                if (IsValid)
                {
                    var KeyDevice = await controller.GetOperatorDataAsync(CBOperador.SelectedValue.ToString());
                    SendNotification(assignament.EndPoint, KeyDevice.IdDevice);
                    var list = await controller.GetAllPendingAssignments();
                    formAssignent.RefreshTablePending(list);
                    MessageBox.Show("Se ha asignado viaje correctamente", "Exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, intenta mas tarde", "Error");
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error, intenta mas tarde", "Error");
            }
        }

        public async Task<AssignamentVM> GetAssignamentData()
        {
            var IsValid = ValidationData(CBPay.SelectedValue.ToString());
            if (IsValid)
            {
                
                var user = await controller.GetOperatorDataAsync(CBOperador.SelectedValue.ToString());
                if(user != null)
                {
                    var assignament = new AssignamentVM();
                    assignament.UserKey = user.IdUser;
                    assignament.EndPoint = txtTravelTo.Text;
                    assignament.PointOrigin = txtPointOfOrigin.Text;
                    assignament.PayWay = CBPay.Text;
                    assignament.PhoneNumber = txtPhoneNumber.Text;
                    assignament.StartDate = txtDate.Text;
                    assignament.StartDatetime = txtDatetime.Text;
                    assignament.Total = txtTotal.Text;
                    assignament.UserName = txtName.Text;
                    assignament.Operator = CBOperador.Text;
                    return assignament;
                }
                else
                {
                    return null;
                }
                
            }
            else
            {
                MessageBox.Show("Llena todos los campos", "Alerta");
                return null;
            }

        }

        public bool ValidationData(string payway)
        {
            if (string.IsNullOrEmpty(txtDate.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtDatetime.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtPointOfOrigin.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtTotal.Text) && payway == "0")
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtTravelTo.Text))
            {
                return false;
            }
            return true;
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
