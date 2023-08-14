using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
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
            Loading2.Visible = false;
            RefreshDontConfirmTable();
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
            if (e.ColumnIndex == TripPendingGrid.Columns["Detail"].Index)
            {
                var id = Convert.ToString(TripPendingGrid.Rows[e.RowIndex].Cells["id"].Value);
                GoToAssignamentDetail(id);
            }
        }

        private async void SendNewAssignament_Click(object sender, EventArgs e)
        {
            var user = await controller.GetAllOperators();
            if(user != null)
            {
                var formDetail = new AssignamentDetail(null, this);
                formDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se interrumpio la conexion", "Error");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await SearchByDate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                RefreshDontConfirmTable();
            }
        }

        private async void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;

                Loading2.Visible = true;
                await Task.Delay(500);
                var list = await controller.GetAllConfirmsTravelsAsync(null);
                Loading2.Visible = false;
                if (list != null)
                {
                    RefreshTableConfirms(list);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en la conexion", "Error");
                }
            }
        }

        private async void ConfirmPendingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ConfirmPendingGrid.Columns["DetailConfirm"].Index)
            {
                bool flag = false;
                var key = Convert.ToString(ConfirmPendingGrid.Rows[e.RowIndex].Cells["idconfirm"].Value);
                var id = Convert.ToString(ConfirmPendingGrid.Rows[e.RowIndex].Cells["keyconfirm"].Value);
                AssignamentVM travel = new AssignamentVM();
                if (checkBox1.Checked == true)
                {
                    travel = await controller.GetTravelPendingDetail(id, key);
                    flag = false;
                }
                if (checkBox2.Checked == true)
                {
                    travel = await controller.GetTravelConfirmDetail(id, key);
                    flag = true;
                }
                var formtravel = new TravelDetail(travel, flag, this);
                formtravel.ShowDialog();
            }
        }



        ///-------Methods---------///
        public async void GoToAssignamentDetail(string id)
        {
            LoadingGif.Visible = true;
            await Task.Delay(500);
            var trip = await controller.GetPendingAssignament(id);
            LoadingGif.Visible = false;
            if (trip != null)
            {
                var formDetail = new AssignamentDetail(trip, this);
                formDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ocurrio un error, intenta mas tarde", "Error");
            }
        }

        public void RefreshTableConfirms(List<AssignamentVM> list)
        {
            ConfirmPendingGrid.Rows.Clear();
            foreach (var l in list)
            {
                ConfirmPendingGrid.Rows.Add(l.Key, l.UserKey, l.EndPoint, l.Operator, l.StartDate, "🔎");
            }
            CountLbl.Text = list.Count.ToString();
        }

        public async void RefreshDontConfirmTable()
        {
            Loading2.Visible = true;
            await Task.Delay(500);
            var list = await controller.GetAllTravelsPendingAsync(null);
            Loading2.Visible = false;
            if (list != null)
            {
                RefreshTableConfirms(list);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la conexion", "Error");
            }
        }

        public async Task SearchByDate()
        {
            var date = dateTimePicker2.Value;
            Loading2.Visible = true;
            if (checkBox1.Checked == true)
            {
                var list = await controller.GetAllTravelsPendingAsync(date.ToString("dd/MM/yyyy"));
                RefreshTableConfirms(list);
            }

            if(checkBox2.Checked == true)
            {
                var list = await controller.GetAllConfirmsTravelsAsync(date.ToString("dd/MM/yyyy"));
                RefreshTableConfirms(list);
            }
            Loading2.Visible = false;
        }

        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        public void RefreshTablePending(List<TripVM> list)
        {
            if (list != null)
            {
                TripPendingGrid.Rows.Clear();
                foreach (var l in list)
                {
                    TripPendingGrid.Rows.Add(l.Key, l.EndPoint, l.StartDate, l.StartDateTime, "🔎");
                }
                txtCount.Text = list.Count.ToString();
            }
            else
            {
                MessageBox.Show("Se interrumpio la conexion", "Error");
            }
        }
    }
}
