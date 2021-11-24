using DataLayer.DataKeep;
using LogicLayer;
using LogicLayer.LogicKeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.Keep
{
    public partial class FrmKeep : Form
    {
        SqlConnection _connection;
        ServiceKeep serviceKeep;
        public FrmKeep(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            serviceKeep = new ServiceKeep(_connection);
        }

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Deselect();
            FrmListPatients date = new FrmListPatients(_connection);
            date.Show();
            this.Close();
        }

        private void DgvKeep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvKeep.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Enabled = true;

                GlobalRepositoty.Instance.appointment = serviceKeep.GetById(GlobalRepositoty.Instance.id);
                if (GlobalRepositoty.Instance.appointment.StatusAppointment == 1)
                {
                    BtnConsult.Visible = true;
                }
                else if (GlobalRepositoty.Instance.appointment.StatusAppointment == 2)
                {
                    BtnCheck.Enabled = true;
                }
                else
                {
                    BtnSee.Visible = true;
                }
            }
        }
        #endregion

        #region Private Metodos

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            serviceKeep.Delete(GlobalRepositoty.Instance.id);
            LoadData();
        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmKeep_Load(object sender, EventArgs e)
        {
            LoadData();
            DgvKeep.Columns[0].Visible = false;
        }
        private void LoadData()
        {
            DgvKeep.DataSource = serviceKeep.GetAll();
            DgvKeep.ClearSelection();
            Deselect();
        }
        private void Deselect()
        {
            DgvKeep.ClearSelection();
            BtnDeselect.Enabled = false;
            BtnConsult.Visible = false;
            BtnCheck.Visible = false;
            BtnSee.Visible = false;
            BtnDeselect.Enabled = false;

            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.index = -1;            
        }
        #endregion

    }
}
