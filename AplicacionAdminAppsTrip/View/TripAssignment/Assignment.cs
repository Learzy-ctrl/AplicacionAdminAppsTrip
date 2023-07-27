using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.TripAssignment
{
    public partial class Assignment : Form
    {
        private List<Form> forms = null;
        private readonly TripAssignamentController controller = null;
        public Assignment()
        {
            InitializeComponent();
            forms = new List<Form>();
            controller = new TripAssignamentController();
            LoadingGif.Visible = false;
        }

        private void Assignment_FormClosed(object sender, FormClosedEventArgs e)
        {
            var firstform = forms.FirstOrDefault();
            firstform.Close();
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            var menu = forms.LastOrDefault();
            menu.Show();
            this.Hide();
        }

        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        public  void RefreshTablePending(List<TripVM> list)
        {
            TripPendingGrid.Rows.Clear();
            foreach(var l in list)
            {
                TripPendingGrid.Rows.Add(l.Key, l.EndPoint, l.StartDate, l.StartDateTime, "🔎");
            }
            txtCount.Text = list.Count.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;
            var list = await controller.GetAllPendingAssignments();
            RefreshTablePending(list);
            LoadingGif.Visible = false;
        }

        private async void SearchDateBtn_Click(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;
            var date = DatePicker1.Value;
            var list = await controller.GetPendingsAssignamentsForDate(date.ToString("dd/MM/yyyy"));
            RefreshTablePending(list);
            LoadingGif.Visible = false;
        }

        private async void Assignment_Load(object sender, EventArgs e)
        {
            var list = await controller.GetAllPendingAssignments();
            RefreshTablePending(list);
        }

        private void TripPendingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == TripPendingGrid.Columns["Detail"].Index)
            {
                var id = Convert.ToString(TripPendingGrid.Rows[e.RowIndex].Cells["id"].Value);
                GoToAssignamentDetail(id);
            }
        }

        public async void GoToAssignamentDetail(string id)
        {
            LoadingGif.Visible = true;
            await Task.Delay(500);
            var trip = await controller.GetPendingAssignament(id);
            LoadingGif.Visible = false;
            if(trip != null)
            {
                var formDetail = new AssignamentDetail(trip);
                formDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ocurrio un error, intenta mas tarde", "Error");
            }
        }

        private void SendNewAssignament_Click(object sender, EventArgs e)
        {
            var formDetail = new AssignamentDetail(null);
            formDetail.ShowDialog();
        }
    }
}
