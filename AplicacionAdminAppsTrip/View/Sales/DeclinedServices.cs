using AplicacionAdminAppsTrip.Controller;
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
    public partial class DeclinedServices : Form
    {
        private Sales sales1 = null;
        private readonly SalesController controller = null;
        public DeclinedServices()
        {
            InitializeComponent();
            sales1 = new Sales();
            controller = new SalesController();
        }
        //Functions
        private void Backbtn_Click(object sender, EventArgs e)
        {
            sales1.Show();
            this.Close();
        }
        private void DeclinedServices_FormClosed(object sender, FormClosedEventArgs e)
        {
            sales1.Show();
        }
        private async void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadingGif.Show();
            await RefreshTable();
            LoadingGif.Hide();
        }

        private async void DeclinedServices_Load(object sender, EventArgs e)
        {
            await RefreshTable();
            LoadingGif.Hide();
        }

        //Methods
        public void SetFormPrevious(Sales sales)
        {
            sales1 = sales;
        }
        public async Task RefreshTable()
        {
            var RejectedTrip = await controller.GetAllTripRejected(true);
            if(RejectedTrip == null)
            {
                MessageBox.Show("Conectate a internet", "Alerta");
                return;
            }
            dataGridView1.Rows.Clear();
            foreach(var r in RejectedTrip)
            {
                dataGridView1.Rows.Add(r.Key, r.UserId, r.EndPoint, r.QuoteDateSent, r.QuoteDateRejected, "🔎");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["Detail"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Key"].Value);
                string UserID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
                SendToTripDetail(key, UserID);
            }
        }
        public async void SendToTripDetail(string key, string UserID)
        {
            LoadingGif.Show();
            var RejectedTrip = await controller.GetTripRejectedDetail(key, UserID);
            if(RejectedTrip == null)
            {
                LoadingGif.Hide();
                MessageBox.Show("Conectate a internet", "Alerta");
                return;
            }
            LoadingGif.Hide();
            TripDetail trip = new TripDetail(RejectedTrip, sales1, this);
            trip.ShowDialog();
        }
    }
}
