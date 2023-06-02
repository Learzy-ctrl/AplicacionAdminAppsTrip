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

namespace AplicacionAdminAppsTrip.View.Login
{
    public partial class Login : Form
    {
        private readonly Menu FormMenu = null;
        public Login()
        {
            InitializeComponent();
            FormMenu = new Menu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Form> secundaryforms = new List<Form>();
            secundaryforms.Add(this);
            FormMenu.Show();
            FormMenu.SetFormList(secundaryforms);
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
