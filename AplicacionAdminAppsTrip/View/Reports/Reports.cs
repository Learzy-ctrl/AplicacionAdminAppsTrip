using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.Reports
{
    public partial class Reports : Form
    {
        private List<Form> forms = null;
        public Reports()
        {
            InitializeComponent();
            forms = new List<Form>();
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            var menu = forms.LastOrDefault();
            menu.Show();
            this.Hide();
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            var firstform = forms.FirstOrDefault();
            firstform.Close();
        }

        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }
    }
}
