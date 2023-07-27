using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.ViewModel;
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
        public AssignamentDetail(TripVM pending)
        {
            InitializeComponent();
            controller = new TripAssignamentController();
            PrintData(pending);
            PrintComboBox();
        }

        public void PrintData(TripVM trip)
        {
            if(trip != null)
            {
                txtTravelTo.Text = trip.EndPoint;
                txtDate.Text = trip.StartDate;
                txtDatetime.Text = trip.StartDateTime;
                txtPointOfOrigin.Text = trip.PointOrigin;
                txtPhoneNumber.Text = trip.PhoneNumber;
                txtName.Text = trip.Name;

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
            if(Operators != null)
            {
                var list = new List<UserVM>();
                foreach(var o in Operators)
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

        public async void GetOperatorData()
        {
            
        }

        private void CBPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = CBPay.SelectedValue.ToString();
            if(id == "1")
            {
                txtTotal.Enabled = false;
                txtTotal.Text = "";
            }
            else
            {
                txtTotal.Enabled = true;
            }
        }

        private void btnSendAssignament_Click(object sender, EventArgs e)
        {
            var assignament = new AssignamentVM();
            assignament.Key = 
        }
    }
}
