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
    public partial class Sales : Form
    {
        private List<Form> forms = null;
        public Sales()
        {
            InitializeComponent();
            forms = new List<Form>();
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            var text = forms.LastOrDefault().Text;

            if (text != "Sales")
            {
                foreach (var l in forms)
                {
                    l.Close();
                }
            }
        }
        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.Menu MenuForm = new Menu();
            var FirstForm = forms.FirstOrDefault();
            var PreviousForm = forms.LastOrDefault();

            forms.Clear();
            forms.Add(FirstForm);
            forms.Add(this);

            MenuForm = (Menu)PreviousForm;
            MenuForm.SetFormList(forms);
            MenuForm.Show();
            this.Hide();
        }
    }
}
