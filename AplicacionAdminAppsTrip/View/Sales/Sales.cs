using AplicacionAdminAppsTrip.Controller;
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

namespace AplicacionAdminAppsTrip.View.Sales
{
    public partial class Sales : Form
    {
        private List<Form> forms = null;
        public Sales()
        {
            InitializeComponent();
            forms = new List<Form>();
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
        public void RefreshTable()
        {
            var lista = Data();
            dataGridView1.Rows.Clear();
            foreach(var l in lista)
            {
                dataGridView1.Rows.Add(l.Key, l.PointEnd, l.StartDate, l.StartDateTime, "🔎");
            }
        }

        public List<TripVM> Data()
        {
            List<TripVM> ListTripVM = new List<TripVM>();
            TripVM tripVM = new TripVM();
            TripVM tripVM1 = new TripVM();
            TripVM tripVM2 = new TripVM();
            tripVM.Key = "12345678";
            tripVM.PointEnd = "Las Catacumbas de Guanajuato";
            tripVM.PointOrigin = "Tulacingo de allende";
            tripVM.StartDate = "06/06/2023";
            tripVM.EndDate = "08/06/2023";
            tripVM.StartDateTime = "06:30";
            tripVM.EndDateTime = "20:00";
            tripVM.RoundTrip = "Si";
            tripVM.NumberPassangers = "12";
            tripVM.NameUser = "Rogelio de santacruz zaragosa";
            tripVM.PhoneNumber = "7754219546";

            tripVM1.Key = "1397";
            tripVM1.PointEnd = "Las Catacumbas de Guanajuato";
            tripVM1.PointOrigin = "Tulacingo de allende";
            tripVM1.StartDate = "06/06/2023";
            tripVM1.EndDate = "08/06/2023";
            tripVM1.StartDateTime = "06:30";
            tripVM1.EndDateTime = "20:00";
            tripVM1.RoundTrip = "Si";
            tripVM1.NumberPassangers = "12";
            tripVM1.NameUser = "Rogelio de santacruz zaragosa";
            tripVM1.PhoneNumber = "7754219546";

            tripVM2.Key = "87654321";
            tripVM2.PointEnd = "Las Catacumbas de Guanajuato";
            tripVM2.PointOrigin = "Tulacingo de allende";
            tripVM2.StartDate = "06/06/2023";
            tripVM2.EndDate = "08/06/2023";
            tripVM2.StartDateTime = "06:30";
            tripVM2.EndDateTime = "20:00";
            tripVM2.RoundTrip = "Si";
            tripVM2.NumberPassangers = "12";
            tripVM2.NameUser = "Rogelio de santacruz zaragosa";
            tripVM2.PhoneNumber = "7754219546";

            ListTripVM.Add(tripVM);
            ListTripVM.Add(tripVM1);
            ListTripVM.Add(tripVM2);
            return ListTripVM;
        }

        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        public void SendDataToTripDetail(string Key)
        {
            TripDetail tripDetail = new TripDetail();
            var List = Data();
            var Trip = List.First(a => a.Key == Key);
            tripDetail.GetDataFromSales(Trip);
            tripDetail.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Key"].Value);
                SendDataToTripDetail(key);
            }
        }
    }
}
