using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.View.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View
{
    public partial class Menu : Form
    {
        private readonly Sales.Sales salesForm = null;
        private List<Form> forms = null;
        public Menu()
        {
            InitializeComponent();
            salesForm = new Sales.Sales();  
            forms = new List<Form>();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var text = forms.LastOrDefault().Text;
            if(text != "Sales")
            {
                forms.Add(this);
                salesForm.Show();
                salesForm.SetFormList(forms);
                this.Hide();
            }
            else
            {
                var FirstForm = forms.FirstOrDefault();
                forms.Clear();
                forms.Add(FirstForm);

                forms.Add(this);
                salesForm.Show();
                salesForm.SetFormList(forms);
                this.Hide();
            }

            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            foreach (var l in forms)
            {
                l.Close();
            }
            this.Close();
        }
        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }
    }
}
