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
        }
        private void Deselect()
        {
            DgvKeep.ClearSelection();
            BtnDeselect.Visible = false;
            BtnConsult.Visible = false;
            BtnCheck.Visible = false;
            BtnSee.Visible = false;
            BtnDeselect.Enabled = false;

            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.index = -1;            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmDate date = new FrmDate();
            date.Show();
            this.Close();
        }

        private void DgvKeep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvKeep.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.appointment = serviceKeep.GetById(GlobalRepositoty.Instance.id);
            }
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
    }
}
