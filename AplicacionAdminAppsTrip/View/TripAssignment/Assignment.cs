using AplicacionAdminAppsTrip.Controller;
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

        public async Task RefreshTablePending()
        {
            var list = await controller.GetAllPendingAssignments();
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
            await RefreshTablePending();
            LoadingGif.Visible = false;
        }
    }
}
