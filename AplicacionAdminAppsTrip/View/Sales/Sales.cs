using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Services;
using AplicacionAdminAppsTrip.ViewModel;
using FirebaseAdmin;
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
        private Timer timer;
        public Sales()
        {
            InitializeComponent();
            forms = new List<Form>();
            salesController = new SalesController();
            InitializeTimer();
            LoadingGif.Hide();
        }

        //Functions
        private async void timer1_Tick(object sender, EventArgs e)
        {
            await RefreshTable();
            await RefreshCountButtons();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 300000; // for each 5 minutes
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            var firstform = forms.FirstOrDefault();
            firstform.Close();
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Key"].Value);
                string UserID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
                LoadingGif.Show();
                await SendDataToTripDetail(key, UserID);
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
        private async void Sales_Load(object sender, EventArgs e)
        {
            LoadingGif.Show();
            await RefreshTable();
            await RefreshCountButtons();
            LoadingGif.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var menu = forms.LastOrDefault();
            menu.Show();
            this.Hide();
        }
        private async void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadingGif.Show();
            await RefreshTable();
            await RefreshCountButtons();
            LoadingGif.Hide();
        }


        //Metods
        public async Task RefreshTable()
        {
            var List = await QuoteTrips();
            if(List != null)
            {
                dataGridView1.Rows.Clear();
                foreach (var l in List)
                {
                    dataGridView1.Rows.Add(l.UserId, l.Key, l.EndPoint, l.StartDate, l.StartDateTime, "🔎");
                }
            }
            else
            {
                MessageBox.Show("Estas desconectado de la red", "Error");
            }
            
        }

        public async Task<List<TripVM>> QuoteTrips()
        {
            List<TripVM> tripVMs = new List<TripVM>();
            var ListOfLists = await salesController.GetAllQuotes();
            if(ListOfLists != null)
            {
                foreach (var l in ListOfLists)
                {
                    foreach (var li in l)
                    {   
                        tripVMs.Add(li);
                    }
                }
                return tripVMs;
            }
            else
            {
                return null;
            }
        }

        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        public async Task SendDataToTripDetail(string Key, string Id)
        {
            var Trip = await salesController.GetTripDetail(Key, Id);
            if(Trip == null)
            {
                LoadingGif.Hide();
                MessageBox.Show("Conectate a internet", "Alerta");
                return;
            }
            var form = this;
            TripDetail tripDetail = new TripDetail(Trip, form, null);
            LoadingGif.Hide();
            tripDetail.ShowDialog();
        }

        public async Task RefreshCountButtons()
        {
            var countConfirm = await salesController.GetCountConfirm();
            var countRejected = await salesController.GetCountRejected();
            if(countRejected != -1 || countConfirm != -1)
            {
                ServicesConfirmbtn.Text = "Servicios Confirmados " + "( " + countConfirm + " )";
                DeclinedServicesbtn.Text = "Servicios Rechazados " + "( " + countRejected + " )";
            }
        }
        
    }
}
