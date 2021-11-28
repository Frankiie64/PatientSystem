using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.Models;
using LogicLayer;
using LogicLayer.Usuario;
using PatientSystem.Login;
using PatientSystem.Home;
using PatientSystem;


namespace PatientSystem.User
{
    public partial class FrmUser : Form
    {
        SqlConnection _connection;
        ServiceUsers _service;
        private bool Login = false;
        private object Mantenices = new object();
        public FrmUser(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _service = new ServiceUsers(_connection);

        }

        // Eventos del menu strip
        #region Menu Options
        private void goBackHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = true;
            this.Close();
        }
        private void maintenanceUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsersMetodo();
        }
        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUsersMetodo();
        }
        private void deleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUsersMetodo();
        }
        private void patientMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = true;
            Mantenices = true;
            this.Close();
        }

        private void keepingMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = true;
            Mantenices = false;
            this.Close();
        }

        #endregion

        //Eventos generales de la  app, como el load, los btn, dgv...
        #region Events
        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clucht();
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            loadData();
            DgvUser.Columns[0].Visible = false;
            Deselect();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvUser.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.Usuario = _service.GetById(GlobalRepositoty.Instance.id);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteUsersMetodo();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddUsersMetodo();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditUsersMetodo();
        }

        #endregion

        //Metodos para el desarrllo de lo anterior
        #region Metodos Privados
        public void loadData()
        {
            DgvUser.DataSource = _service.LoadTable();
            DgvUser.ClearSelection();
        }
        public void Deselect()
        {
            DgvUser.ClearSelection();
            BtnDeselect.Visible = false;
            GlobalRepositoty.Instance.index = -1;
            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.Usuario = new Users();

        }
        private void GoBackHome()
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
        }
        private void AddUsersMetodo()
        {
            Deselect();
            FrmAddUsers Add = new FrmAddUsers(FrmLogin.Intance.connectionString);
            this.Hide();
            Add.Show();
        }
        private void EditUsersMetodo()
        {
            FrmAddUsers Edit = new FrmAddUsers(FrmLogin.Intance.connectionString);
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Editar", "Error");
            }
            else
            {
                this.Hide();
                Edit.Show();
            }
        }
        private void DeleteUsersMetodo()
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Eliminar", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar este usuario ?", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (GlobalRepositoty.Instance.UserId == GlobalRepositoty.Instance.id)
                    {
                        MessageBox.Show("Profe, usted no corre. Busquese a otro grupo pa' tripiar", "Burlao'");
                    }
                    else
                    {
                        if (_service.DeleteUser(GlobalRepositoty.Instance.id))
                        {
                            MessageBox.Show("Se ha eliminado correctamente", "Eliminacion del usario");
                            loadData();
                            Deselect();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error", "Error");
                            loadData();
                            Deselect();
                        }
                    }
                }
                else
                {
                    Deselect();
                }
            }
        }

        private void Clucht()
        {
            try
            {
                if (Login)
                {
                    if (Mantenices == new object())
                    {
                        FrmLogin.Intance.Show();
                    }
                    else if ((bool)Mantenices)
                    {
                        Medical.FrmMedical doc = new Medical.FrmMedical(_connection);
                        doc.Show();
                    }
                    else if (!(bool)Mantenices)
                    {
                        Lab.FrmLabTest test = new Lab.FrmLabTest(_connection);
                        test.Show();
                    }
                }
                else
                {
                    GoBackHome();
                }
            }
            catch (Exception ex)
            {
                FrmLogin.Intance.Show();
            }
        }
        #endregion


    }


}

