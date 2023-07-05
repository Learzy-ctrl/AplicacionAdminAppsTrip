using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.View.Reports;
using AplicacionAdminAppsTrip.View.Sales;
using AplicacionAdminAppsTrip.View.TripAssignment;
using AplicacionAdminAppsTrip.View.User_Managment;
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

namespace AplicacionAdminAppsTrip.View
{
    public partial class Menu : Form
    {
        private readonly Sales.Sales salesForm = null;
        private readonly Assignment assignamentForm = null;
        private readonly Managment managmentForm = null;
        private readonly Reports.Reports reportsForm = null;
        private List<Form> formList = null;
        private CredentialsVM credentials = null;
        public Menu()
        {
            InitializeComponent();
            salesForm = new Sales.Sales();
            assignamentForm = new Assignment();
            managmentForm = new Managment();
            reportsForm = new Reports.Reports();
            formList = new List<Form>();
            credentials = new CredentialsVM();
            

        }
        private void SalesPicture_Click(object sender, EventArgs e)
        {
            if(credentials.IdAccess == "1" || credentials.IdAccess == "0")
            {
                var firstform = formList.FirstOrDefault();
                formList.Clear();
                formList.Add(firstform);
                formList.Add(this);
                salesForm.SetFormList(formList);
                salesForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes permiso para esta opcion", "Acceso Denegado");
            }
            
        }

        private void AssignamentPicture_Click(object sender, EventArgs e)
        {
            if (credentials.IdAccess == "2" || credentials.IdAccess == "0")
            {
                var firstform = formList.FirstOrDefault();
                formList.Clear();
                formList.Add(firstform);
                formList.Add(this);
                assignamentForm.SetFormList(formList);
                assignamentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes permiso para esta opcion", "Acceso Denegado");
            }
           
        }

        private void UserManagmentPicture_Click(object sender, EventArgs e)
        {
            if(credentials.IdAccess == "0")
            {
                var firstform = formList.FirstOrDefault();
                formList.Clear();
                formList.Add(firstform);
                formList.Add(this);
                managmentForm.SetFormList(formList);
                managmentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes permiso para esta opcion", "Acceso Denegado");
            }
            
        }

        private void ReportsPicture_Click(object sender, EventArgs e)
        {
            var firstform = formList.FirstOrDefault();
            formList.Clear();
            formList.Add(firstform);
            formList.Add(this);
            reportsForm.SetFormList(formList);
            reportsForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var form = formList.FirstOrDefault();
            form.Close();
        }

        public void SetFormList(List<Form> Listform)
        {
            formList = Listform;
        }

        public void SetCredentials(CredentialsVM credentialVM)
        {
            credentials = credentialVM;
            txtNameUser.Text = credentials.Name;
        }
    }
}
