using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.Sales
{
    public partial class ServicesConfirm : Form
    {
        private Sales sales1 = null;
        private readonly SalesController controller = null;
        public ServicesConfirm()
        {
            InitializeComponent();
            sales1 = new Sales();
            controller = new SalesController();
        }

        //Functions
        private void ServicesConfirm_FormClosed(object sender, FormClosedEventArgs e)
        { 
            sales1.Show();
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            sales1.Show();
            this.Close();
        }
        private async void ServicesConfirm_Load(object sender, EventArgs e)
        {
            await RefreshTable();
            LoadingGif.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detailbtn"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Key"].Value);
                string UserID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
                SendDataToTripDetail(key, UserID);
            }
        }
        private async void RefreshAllbtn_Click(object sender, EventArgs e)
        {
            LoadingGif.Show();
            await RefreshTable();
            LoadingGif.Hide();
        }
        private async void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadingGif.Show();
            var xd = DatePicker.Value.ToString("dd/MM/yyyy");
            await RefreshTable(xd);
            LoadingGif.Hide();
        }

        //Methods
        public async Task RefreshTable()
        {
            try
            {
                var list = await GetAllData();
                if (list != null)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var l in list)
                    {
                        dataGridView1.Rows.Add(l.Key, l.UserId, l.EndPoint, l.QuoteDateConfirmed, l.QuoteDateSent, "🔎");
                    }
                }
                else
                {
                    MessageBox.Show("Conectate a internet", "Error");
                }
            }
            catch
            {

            }
            
        }
        public async Task RefreshTable(string Date)
        {
            var list = await GetAllData(Date);
            if (list != null)
            {
                dataGridView1.Rows.Clear();
                foreach (var l in list)
                {
                    dataGridView1.Rows.Add(l.Key, l.UserId, l.EndPoint, l.QuoteDateConfirmed, l.QuoteDateSent, "🔎");
                }
            }
            else
            {
                MessageBox.Show("Conectate a internet", "Error");
            }
        }
        public async Task<List<TripVM>> GetAllData()
        {
            List<TripVM> tripVMs = new List<TripVM>();
            var data = await controller.GetAllConfirmQuotes();
            if(data != null)
            {
                foreach (var li in data)
                {
                    foreach (var l in li)
                    {
                        tripVMs.Add(l);
                    }
                }
                return tripVMs;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<TripVM>> GetAllData(string date)
        {
            List<TripVM> tripVMs = new List<TripVM>();
            var data = await controller.GetAllConfirmQuotes();
            if (data != null)
            {
                foreach (var li in data)
                {
                    foreach (var l in li)
                    {
                        tripVMs.Add(l);
                    }
                }
                var TripVM = tripVMs.Where(l => l.QuoteDateConfirmed == date);
                return TripVM.ToList();
            }
            else
                {
                return null;
            }
        }
        public async void SendDataToTripDetail(string Key, string Id)
        {
            LoadingGif.Show();
            var Trip = await controller.GetConfirmTripdetail(Key, Id);
            if(Trip == null)
            {
                LoadingGif.Hide();
                MessageBox.Show("Conectate a internet", "Alerta");
                return;
            }
            TripDetail tripDetail = new TripDetail(Trip, null, null);
            LoadingGif.Hide();
            tripDetail.ShowDialog();
        }
        public void SetFormPrevious(Sales sales)
        {
            sales1 = sales;
        }
    }
}
