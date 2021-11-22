using LogicLayer;
using LogicLayer.TestResult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.ResultTest
{
    public partial class FrmResultLab : Form
    {
        SqlConnection _cn;
        TestResultService _service;
        public FrmResultLab()
        {
            InitializeComponent();

        }

        private void FrmResultLab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvResultLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvResultLab.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.result = _service.GetById(GlobalRepositoty.Instance.id);
            }
        }
        private void LoadData()
        {
            DgvResultLab.DataSource = _service.GetAll();
            DgvResultLab.ClearSelection();
        }
        public void Deselect()
        {
            DgvResultLab.ClearSelection();
            BtnDeselect.Visible = false;
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmReport report = new FrmReport();
            this.Hide();
            report.Show();
        }
    }
}
