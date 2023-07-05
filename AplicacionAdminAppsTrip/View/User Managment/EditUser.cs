using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.User_Managment
{
    public partial class EditUser : Form
    {
        bool PasswordEnable = true;
        bool ConfirmPasswordEnable = true;
        string key;
        Managment managment = null;
        private readonly UserManagmentController controller = null;
        public EditUser(UserVM user, Managment formManagment)
        {
            InitializeComponent();
            controller = new UserManagmentController();
            key = user.IdUser;
            managment = formManagment;
            ComboBoxSetData();
            SetUserData(user);
            LoadingGif.Visible = false;
        }
        //functions
        private void btnShowPassword_Click_1(object sender, EventArgs e)
        {
            if (PasswordEnable)
            {
                txtPassword.UseSystemPasswordChar = false;
                PasswordEnable = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                PasswordEnable = true;
            }
        }

        private void btnShowConfirmPassword_Click_1(object sender, EventArgs e)
        {
            if (ConfirmPasswordEnable)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                ConfirmPasswordEnable = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                ConfirmPasswordEnable = true;
            }
        }

        private async void btnSubmit_Click_1(object sender, EventArgs e)
        {
            var IsValid = ValidateData();
            if (IsValid)
            {
                LoadingGif.Visible = true;
                await Task.Delay(500);
                var response = await controller.PutUserAsync(GetUser());
                LoadingGif.Visible = false;
                if (response)
                {
                    MessageBox.Show("Se ha registrado correctamente", "Exito");
                    managment.RefreshTable("");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un fallo con la conexion de internet", "Error");
                }

            }
        }



        //----Methods Validation----//
        public bool ValidateData()
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Ingresa Nombre", "Alerta");
                return false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Ingresa Apellidos", "Alerta");
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Ingresa Numero celular", "Alerta");
                return false;
            }
            if (!ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Ingresa un numero valido", "Alerta");
                return false;
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!ValidateEmail(txtEmail.Text))
                {
                    MessageBox.Show("Ingresa un correo valido", "Alerta");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingresa contraseña", "Alerta");
                return false;
            }
            if (txtPassword.Text.Count() < 6)
            {
                MessageBox.Show("La contraseña debe ser mayor a 6 caracteres", "Alerta");
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Confirma tu contraseña", "Alerta");
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("La confirmacion no coincide con la contraseña", "Alerta");
                return false;
            }
            return true;
        }

        public bool ValidatePhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber.Count() != 10)
            {
                return false;
            }
            string patron = @"^[0-9]+$";
            bool IsValid = Regex.IsMatch(PhoneNumber, patron);
            return IsValid;
        }

        public bool ValidateEmail(string Email)
        {
            string patron = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            bool IsValid = Regex.IsMatch(Email, patron);
            return IsValid;
        }

        ///Methods
        public void SetUserData(UserVM user)
        {
            txtname.Text = user.Name;
            txtLastName.Text = user.LastName;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtConfirmPassword.Text = user.Password;
            RolComboBox.SelectedIndex = int.Parse(user.Rol);
        }

        public void ComboBoxSetData()
        {
            List<ConsultationVM> DataList = new List<ConsultationVM>();
            DataList.Add(new ConsultationVM { Name = "Administrador", Id = "0" });
            DataList.Add(new ConsultationVM { Name = "Ventas", Id = "1" });
            DataList.Add(new ConsultationVM { Name = "Logistica", Id = "2" });
            DataList.Add(new ConsultationVM { Name = "Operador", Id = "3" });
            RolComboBox.DataSource = DataList;
            RolComboBox.ValueMember = "Id";
            RolComboBox.DisplayMember = "Name";
        }

        public UserVM GetUser()
        {
            var user = new UserVM();
            user.Name = txtname.Text;
            user.LastName = txtLastName.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.Rol = RolComboBox.SelectedValue.ToString();
            user.IdUser = key;
            return user;
        }

        
    }
}
