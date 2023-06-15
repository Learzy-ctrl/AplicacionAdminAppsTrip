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
    public partial class ServicesConfirm : Form
    {
        private Sales sales1 = null;
        public ServicesConfirm()
        {
            InitializeComponent();
            sales1 = new Sales();
        }

        public void SetFormPrevious(Sales sales)
        {
            sales1 = sales;
        }

        private void ServicesConfirm_FormClosed(object sender, FormClosedEventArgs e)
        { 
            sales1.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            sales1.Show();
            this.Close();
        }
    }
}
