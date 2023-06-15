using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.Sales
{
    public partial class Sales : Form
    {
        private List<Form> forms = null;
        private readonly SalesController salesController = null;
        public Sales()
        {
            InitializeComponent();
            forms = new List<Form>();
            salesController = new SalesController();
        }

        //Functions
        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            var firstform = forms.FirstOrDefault();
            firstform.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = forms.LastOrDefault();
            menu.Show();
            this.Hide();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }


        //Metods
        public async void RefreshTable()
        {
            var List = await QuoteTrips();
            dataGridView1.Rows.Clear();
            foreach (var l in List)
            {
                dataGridView1.Rows.Add(l.UserId, l.Key, l.EndPoint, l.StartDate, l.StartDateTime, "🔎");
            }
        }

        public async Task<List<TripVM>> QuoteTrips()
        {
            List<TripVM> tripVMs = new List<TripVM>();
            var ListOfLists = await salesController.GetAllQuotes();
            foreach (var l in ListOfLists)
            {
                foreach (var li in l)
                {
                    tripVMs.Add(li);
                }
            }
            return tripVMs;
        }

        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        public async void SendDataToTripDetail(string Key, string Id)
        {
            var Trip = await salesController.GetTripDetail(Key, Id);
            TripDetail tripDetail = new TripDetail(Trip);
            tripDetail.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Key"].Value);
                string UserID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
                SendDataToTripDetail(key, UserID);
            }
        }

        private void ServicesConfirmbtn_Click(object sender, EventArgs e)
        {
            ServicesConfirm servicesConfirm = new ServicesConfirm();
            servicesConfirm.SetFormPrevious(this);
            servicesConfirm.Show();
            this.Hide();
        }

        private void DeclinedServicesbtn_Click(object sender, EventArgs e)
        {
            DeclinedServices declinedServices = new DeclinedServices();
            declinedServices.SetFormPrevious(this);
            declinedServices.Show();
            this.Hide();
        }
    }
}
