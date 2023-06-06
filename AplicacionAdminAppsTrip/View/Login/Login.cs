using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Validation();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void Validation() 
        {
            var user = credential();
            if (user.Name.ToLower() == "david" && user.Password == "1234")
            {
                List<Form> Primaryform = new List<Form>();
                Primaryform.Add(this);
                user.IdAccess = "4";
                FormMenu.SetCredentials(user);
                FormMenu.Show();
                FormMenu.SetFormList(Primaryform);
                this.Hide();
            } 
            else
            {
                MessageBox.Show("La contraseña o usuario son incorrectos, intenta de nuevo", "Error");
                txtName.Text = "";
                txtPassword.Text = "";
            }
        }

        public CredentialsVM credential()
        {
            CredentialsVM credentialsVM = new CredentialsVM();
            credentialsVM.Name = txtName.Text;
            credentialsVM.Password = txtPassword.Text;

            return credentialsVM;
        }
    }
}
