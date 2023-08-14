using AplicacionAdminAppsTrip.Controller;
using AplicacionAdminAppsTrip.Model;
using AplicacionAdminAppsTrip.ViewModel;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat;

namespace AplicacionAdminAppsTrip.View.Reports
{
    public partial class Reports : Form
    {
        private readonly SalesController salescontroller = null;
        private readonly TripAssignamentController assignmentcontroller = null;
        private readonly UserManagmentController usercontroller = null;
        private List<Form> forms = null;
        public Reports()
        {
            InitializeComponent();
            LoadingGif.Visible = false;
            LoadingGif2.Visible = false;
            LoadingGif3.Visible = false;
            forms = new List<Form>();
            salescontroller = new SalesController();
            assignmentcontroller = new TripAssignamentController();
            usercontroller = new UserManagmentController();
        }

        public void SetDataToTripTable(List<TripVM> list)
        {
            TripTable.Rows.Clear();
            foreach (var l in list)
            {
                if (string.IsNullOrEmpty(l.FeedBack))
                {
                    l.FeedBack = "Sin comentarios";
                }
                if (string.IsNullOrEmpty(l.TotalPrice))
                {
                    l.TotalPrice = "sin precio cotizado";
                }
                TripTable.Rows.Add(l.PointOrigin, l.EndPoint, l.Name, l.PhoneNumber, l.StartDate, l.EndDate, l.StartDateTime, l.BackDateTime, l.Rounded, l.NumberPassengers, l.TotalPrice, l.FeedBack);
            }
            txtCount1.Text = list.Count.ToString();
        }

        private async void cbConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirm.Checked)
            {
                LoadingGif.Visible = true;
                await Task.Delay(500);
                cbCancelled.Checked = false;
                cbRejected.Checked = false;
                var listoflist = await salescontroller.GetAllConfirmQuotes();
                LoadingGif.Visible = false;
                if (listoflist != null)
                {
                    var list = new List<TripVM>();
                    foreach (var list1 in listoflist)
                    {
                        foreach (var l in list1)
                        {
                            list.Add(l);
                        }
                    }
                    SetDataToTripTable(list);
                }
                else
                {
                    MessageBox.Show("Error en la conexion de internet", "Error");
                }
            }
        }

        private async void cbRejected_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRejected.Checked)
            {
                LoadingGif.Visible = true;
                await Task.Delay(500);
                cbCancelled.Checked = false;
                cbConfirm.Checked = false;
                var list = await salescontroller.GetAllTripRejected(false);
                LoadingGif.Visible = false;
                if (list != null)
                {
                    SetDataToTripTable(list);
                }
                else
                {
                    MessageBox.Show("Error en la conexion de internet", "Error");
                }
            }
        }

        private async void cbCancelled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCancelled.Checked)
            {
                LoadingGif.Visible = true;
                await Task.Delay(500);
                cbRejected.Checked = false;
                cbConfirm.Checked = false;
                var list = await salescontroller.GetAllCancelledTripAsync();
                LoadingGif.Visible = false;
                if (list != null)
                {
                    SetDataToTripTable(list);
                }
                else
                {
                    MessageBox.Show("Error en la conexion de internet", "Error");
                }
            }
        }


        public void SetDataToAssignmentTable(List<AssignamentVM> list)
        {
            AssignmentTable.Rows.Clear();
            foreach (var l in list)
            {
                AssignmentTable.Rows.Add(l.PointOrigin, l.EndPoint, l.UserName, l.PhoneNumber, l.Operator, l.StartDate, l.StartDatetime, l.PayWay, l.DateConfirm, l.Total);
            }
            txtCount2.Text = list.Count.ToString();
        }

        public void SetDataToUsersTable(List<UserVM> list)
        {
            UsersTable.Rows.Clear();
            foreach (var l in list)
            {
                UsersTable.Rows.Add(l.Name, l.LastName, l.Email, l.PhoneNumber);
            }
            txtCount3.Text = list.Count.ToString();
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

        private async void btnAssignmentRefresh_Click(object sender, EventArgs e)
        {
            LoadingGif2.Visible = true;
            await Task.Delay(500);
            var list = await assignmentcontroller.GetAllConfirmsTravelsAsync(null);
            LoadingGif2.Visible = false;
            if (list != null)
            {
                SetDataToAssignmentTable(list);
            }
            else
            {
                MessageBox.Show("Error en la conexion de internet", "Error");
            }
        }

        private async void cbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPersonal.Checked)
            {
                LoadingGif3.Visible = true;
                cbCostumer.Checked = false;
                await Task.Delay(500);
                var list = await usercontroller.GetUsersAsync();
                LoadingGif3.Visible = false;
                if (list != null)
                {
                    SetDataToUsersTable(list);
                }
                else
                {
                    MessageBox.Show("Error en la conexion de internet", "Error");
                }
            }
        }

        private async void cbCostumer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCostumer.Checked)
            {
                LoadingGif3.Visible = true;
                cbPersonal.Checked = false;
                await Task.Delay(500);
                var list = await usercontroller.GetUserCustumersAsync();
                LoadingGif3.Visible = false;
                if (list != null)
                {
                    SetDataToUsersTable(list);
                }
                else
                {
                    MessageBox.Show("Error en la conexion de internet", "Error");
                }
            }
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                var sl = new SLDocument();
                var style = new SLStyle();
                style.Font.FontSize = 12;
                style.Font.Bold = true;
                int iC = 1;
                try
                {
                    foreach (DataGridViewColumn column in TripTable.Columns)
                    {
                        sl.SetCellValue(1, iC, column.HeaderText.ToString());
                        sl.SetCellStyle(1, iC, style);
                        iC++;
                    }

                    var iR = 2;

                    foreach (DataGridViewRow row in TripTable.Rows)
                    {
                        sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                        sl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                        sl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                        sl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                        sl.SetCellValue(iR, 9, row.Cells[8].Value.ToString());
                        sl.SetCellValue(iR, 10, row.Cells[9].Value.ToString());
                        sl.SetCellValue(iR, 11, row.Cells[10].Value.ToString());
                        sl.SetCellValue(iR, 12, row.Cells[11].Value.ToString());
                        iR++;
                    }
                    if (cbConfirm.Checked)
                    {
                        sl.SaveAs(path + "\\Viajes Confirmados.xlsx");
                    }
                    if (cbRejected.Checked)
                    {
                        sl.SaveAs(path + "\\Viajes Rechazados.xlsx");
                    }
                    if (cbCancelled.Checked)
                    {
                        sl.SaveAs(path + "\\Viajes Cancelados.xlsx");
                    }
                    MessageBox.Show("Se a exportado a excel correctamente", "Exportacion exitosa");
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error, itenta mas tarde", "Error al exportar");
                }
            }
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                var sl = new SLDocument();
                var style = new SLStyle();
                style.Font.FontSize = 12;
                style.Font.Bold = true;
                int iC = 1;
                try
                {
                    foreach (DataGridViewColumn column in AssignmentTable.Columns)
                    {
                        sl.SetCellValue(1, iC, column.HeaderText.ToString());
                        sl.SetCellStyle(1, iC, style);
                        iC++;
                    }

                    var iR = 2;

                    foreach (DataGridViewRow row in AssignmentTable.Rows)
                    {
                        sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                        sl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                        sl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                        sl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                        sl.SetCellValue(iR, 9, row.Cells[8].Value.ToString());
                        sl.SetCellValue(iR, 10, row.Cells[9].Value.ToString());
                        iR++;
                    }
                    sl.SaveAs(path + "\\Asignaciones confirmadas.xlsx");
                    MessageBox.Show("Se a exportado a excel correctamente", "Exportacion exitosa");
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error, itenta mas tarde", "Error al exportar");
                }
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                var sl = new SLDocument();
                var style = new SLStyle();
                style.Font.FontSize = 12;
                style.Font.Bold = true;
                int iC = 1;
                try
                {
                    foreach (DataGridViewColumn column in UsersTable.Columns)
                    {
                        sl.SetCellValue(1, iC, column.HeaderText.ToString());
                        sl.SetCellStyle(1, iC, style);
                        iC++;
                    }

                    var iR = 2;

                    foreach (DataGridViewRow row in UsersTable.Rows)
                    {
                        sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                        sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                        sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                        sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                        iR++;
                    }
                    if (cbPersonal.Checked)
                    {
                        sl.SaveAs(path + "\\Usuarios(empleados).xlsx");
                    }
                    if (cbCostumer.Checked)
                    {
                        sl.SaveAs(path + "\\Usuarios(clientes).xlsx");
                    }
                    MessageBox.Show("Se a exportado a excel correctamente", "Exportacion exitosa");
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error, itenta mas tarde", "Error al exportar");
                }
            }
        }
    }
}