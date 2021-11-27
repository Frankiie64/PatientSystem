using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer.FolderLabTest;
using LogicLayer;
using DataLayer.Models;
using PatientSystem.Home;
using PatientSystem.Login;

namespace PatientSystem.Lab
{
    public partial class FrmLabTest : Form
    {
        SqlConnection _connection;
        ServiceLabTest service;
        private bool Login = false;
        private object Mantenices = new object();
        public FrmLabTest(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceLabTest(_connection);

        }

        // Eventos del menu strip
        #region Menu Options
        private void MantenimientoUsers_Click(object sender, EventArgs e)
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
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = true;
            this.Close();
        }

        private void goBackHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuTest_Click(object sender, EventArgs e)
        {
            AddTestLab();
        }
        private void MenuEdit_Click(object sender, EventArgs e)
        {
            EditLabTest();
        }
        private void DeleteTest_Click(object sender, EventArgs e)
        {
            DeleteByIdTest();
        }

        #endregion

        // Eventos generales
        #region Events
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditLabTest();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteByIdTest();
        }

        private void FrmLabTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clucht();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddTestLab();
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void FrmLabTest_Load(object sender, EventArgs e)
        {
            loadData();
            DgvLab.Columns[0].Visible = false;
            Deselect();
        }
        private void DgvLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvLab.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.test = service.GetById(GlobalRepositoty.Instance.id);
            }
        }
        #endregion

        //Metodos para el desarrllo de lo anterior
        #region Metodos Privados
        private void EditLabTest()
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Editar", "Error");
            }
            else
            {
                FrmAddTest Edit = new FrmAddTest(_connection);

                this.Hide();
                Edit.Show();
            }
        }

        private void DeleteByIdTest()
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Eliminar", "Error");
            }
            else
            {

                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar esta prueba ?", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (service.DeleteLabTest(GlobalRepositoty.Instance.id))
                    {
                        MessageBox.Show("Se ha elimanado correctamente la prueba", "Notificacion");
                        Deselect();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha elimanado  la prueba", "Notificacion");
                }
            }
            loadData();
        }
        private void GoBackHome()
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
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
                        User.FrmUser user = new User.FrmUser(_connection);
                        user.Show();
                    }
                    else if (!(bool)Mantenices)
                    {
                        Medical.FrmMedical doc = new Medical.FrmMedical(_connection);
                        doc.Show();
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

        private void AddTestLab()
        {
            Deselect();
            FrmAddTest Add = new FrmAddTest(_connection);
            this.Hide();
            Add.Show();
        }

        private void loadData()
        {
            DgvLab.DataSource = service.GetAll();
            DgvLab.ClearSelection();
        }
        public void Deselect()
        {
            DgvLab.ClearSelection();
            BtnDeselect.Visible = false;
            GlobalRepositoty.Instance.index = -1;
            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.test = new LabTest();

        }

        #endregion



        
        

    }
}
