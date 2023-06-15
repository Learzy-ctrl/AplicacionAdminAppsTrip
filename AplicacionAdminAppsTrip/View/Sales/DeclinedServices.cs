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
        public DeclinedServices()
        {
            InitializeComponent();
            sales1 = new Sales();
        }

        public void SetFormPrevious(Sales sales)
        {
            sales1 = sales;
        }
    }
}
