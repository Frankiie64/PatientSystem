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

namespace PatientSystem.Lab
{
    public partial class FrmLabTest : Form
    {
        SqlConnection _connection;
        ServiceLabTest service;
        public FrmLabTest(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceLabTest(_connection);

        }
        private void FrmLabTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmAddTest Edit = new FrmAddTest(_connection);

            this.Hide();
            Edit.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Editar", "Error");
            }
            else
            {

                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar esta prueba ?", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (service.DeleteLabTest(GlobalRepositoty.Instance.id))
                    {
                        MessageBox.Show("Se ha elimanado correctamente la prueba", "Notificacion");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha elimanado  la prueba", "Notificacion");
                }
            }
            loadData();

        }

        
    }
}
