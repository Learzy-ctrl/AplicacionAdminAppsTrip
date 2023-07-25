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
        private readonly LoginController controller = null;
        public Login()
        {
            InitializeComponent();
            controller = new LoginController();
            LoadingGif.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public async void Validation() 
        {
            LoadingGif.Visible = true;
            var user = await controller.AuthenticationAsync(credential());
            LoadingGif.Visible = false;
            if (user.Email == "Error")
            {
                MessageBox.Show("Falla en la conexion a internet", "Error");
            }
            else
            {
                if (user.Email != "Not Found")
                {
                    var FormMenu = new Menu();
                    List<Form> Primaryform = new List<Form>();
                    Primaryform.Add(this);
                    FormMenu.SetCredentials(user);
                    FormMenu.Show();
                    FormMenu.SetFormList(Primaryform);
                    txtName.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contraseña o usuario son incorrectos, intenta de nuevo", "Error");
                    txtName.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        public CredentialsVM credential()
        {   
            CredentialsVM credentialsVM = new CredentialsVM();
            credentialsVM.Email = txtName.Text;
            credentialsVM.Password = txtPassword.Text;

            return credentialsVM;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Validation();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Validation();
            }
        }
    }
}
