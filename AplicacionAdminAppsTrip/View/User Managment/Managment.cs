using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.View.User_Managment
{
    public partial class Managment : Form
    {
        private List<Form> forms = null;
        private readonly UserManagmentController controller = null;
        public Managment()
        {
            InitializeComponent();
            forms = new List<Form>();
            controller = new UserManagmentController();
            LoadingGif.Visible = false;
            ComboBoxSetData();
        }


        //Functions
        private void Managment_FormClosed(object sender, FormClosedEventArgs e)
        {
            var firstform = forms.FirstOrDefault();
            firstform.Close();
        }
        private void CBMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = CBMain.SelectedValue.ToString();
            if (Id != "0")
            {

                if (Id != "3")
                {
                    txtConsultation.Visible = true;
                    btnSubmit.Visible = true;
                    CBRol.Visible = false;
                }
                else
                {
                    txtConsultation.Visible = false;
                    btnSubmit.Visible = false;
                    CBRol.Visible = true;
                }
            }
            else
            {
                txtConsultation.Visible = false;
                btnSubmit.Visible = false;
                CBRol.Visible = false;
                RefreshTable("");
            }
        }
        private void BackToMenuBtn_Click_1(object sender, EventArgs e)
        {
            var menu = forms.LastOrDefault();
            menu.Show();
            this.Hide();
        }
        private void CBRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable(CBRol.SelectedValue.ToString());
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var NewUser = new CreateUser(this);
            NewUser.ShowDialog();
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["userKey"].Value);
                var user = await controller.GetUserAsync(key);
                var edituser = new EditUser(user, this);
                edituser.ShowDialog();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                string key = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["userKey"].Value);
                var Response = MessageBox.Show("¿Estas seguro de eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.OKCancel);
                if(Response == DialogResult.OK)
                {
                    LoadingGif.Visible = true;
                    await Task.Delay(500);
                    var IsDelete = await controller.DeleteUser(key);
                    LoadingGif.Visible = false;
                    RefreshTable("");
                    if (IsDelete)
                    {
                        MessageBox.Show("Se ha eliminado el usuario", "Exito");
                    }
                    else
                    {
                        MessageBox.Show("Se interrumpio la conexion a internet", "Error");
                    }
                }
            }
        }
        private void Managment_Load(object sender, EventArgs e)
        {
            ComboBoxRolSetData();
            txtConsultation.Visible = false;
            btnSubmit.Visible = false;
            CBRol.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConsultation.Text))
            {
                RefreshTable(txtConsultation.Text);
            }
            else
            {
                MessageBox.Show("Ingresa el valor que quieres buscar", "Alerta");
            }

        }


        //Methods
        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }
        public async void RefreshTable(string variable)
        {
            var List = await FilterUser(variable);
            if(List != null)
            {
                dataGridView1.Rows.Clear();
                foreach (var l in List)
                {
                    dataGridView1.Rows.Add(l.IdUser, l.Name, l.LastName, RolUser(l.Rol), l.PhoneNumber, EmailEmpty(l.Email), "📝", "❌");
                }
                txtCount.Text = List.Count.ToString();
            }
            else
            {
                MessageBox.Show("Se interrumpio la conexion a internet", "Error");
            }
        }
        public async Task<List<UserVM>> FilterUser(string variable)
        {
            var List = await controller.GetUsersAsync();
            var option = CBMain.SelectedValue.ToString();
            if(List != null)
            {
                switch (option)
                {
                    case "1":
                        List = List.Where(l => l.Name.ToLower() == variable.ToLower()).ToList();
                        break;
                    case "2":
                        List = List.Where(l => l.LastName.ToLower() == variable.ToLower()).ToList();
                        break;
                    case "3":
                        List = List.Where(l => l.Rol == variable).ToList();
                        break;
                    case "4":
                        List = List.Where(l => l.PhoneNumber == variable).ToList();
                        break;
                    case "5":
                        List = List.Where(l => l.Email.ToLower() == variable.ToLower()).ToList();
                        break;
                }
                return List;
            }
            else
            {
                return List;
            }
        }
        public string RolUser(string rol)
        {
            string NewRol = "";
            switch (rol)
            {
                case "0":
                    NewRol = "Administrador";
                    break;
                case "1":
                    NewRol = "Ventas";
                    break;
                case "2":
                    NewRol = "Logistica";
                    break;
                case "3":
                    NewRol = "Operador";
                    break;
            }
            return NewRol;
        }
        public string EmailEmpty(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "Sin correo electronico";
            }
            else
            {
                return email;
            }
        }
        public void ComboBoxSetData()
        {
            List<ConsultationVM> DataList = new List<ConsultationVM>();
            DataList.Add(new ConsultationVM { Name = "Todo", Id = "0" });
            DataList.Add(new ConsultationVM { Name = "Nombre(s)", Id = "1" });
            DataList.Add(new ConsultationVM { Name = "Apellidos", Id = "2" });
            DataList.Add(new ConsultationVM { Name = "Rol", Id = "3" });
            DataList.Add(new ConsultationVM { Name = "Numero Celular", Id = "4" });
            DataList.Add(new ConsultationVM { Name = "Correo electronico", Id = "5" });
            CBMain.DataSource = DataList;
            CBMain.ValueMember = "Id";
            CBMain.DisplayMember = "Name";
        }
        public void ComboBoxRolSetData()
        {
            List<ConsultationVM> DataList = new List<ConsultationVM>();
            DataList.Add(new ConsultationVM { Name = "Administrador", Id = "0" });
            DataList.Add(new ConsultationVM { Name = "Ventas", Id = "1" });
            DataList.Add(new ConsultationVM { Name = "Logistica", Id = "2" });
            DataList.Add(new ConsultationVM { Name = "Operador", Id = "3" });
            CBRol.DataSource = DataList;
            CBRol.ValueMember = "Id";
            CBRol.DisplayMember = "Name";
        }
    }
}
