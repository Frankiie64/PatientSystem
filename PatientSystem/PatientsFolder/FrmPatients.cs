using DataLayer.Models;
using LogicLayer.PatientLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.Patients
{
    public partial class FrmPatients : Form
    {
        private ServicePatient _service;
        private SqlConnection _connection;
        public int? id = null;
        public FrmPatients(SqlConnection cn)
        {
            InitializeComponent();
            _service = new ServicePatient(cn);
            _connection = cn;
        }

        private void FrmPatients_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPatients frmPatients = new FrmAddPatients(_connection);
            this.Close();
            frmPatients.Show();
        }
        public void Deselect()
        {
            DgvPatients.ClearSelection();
            BtnDeselect.Visible = false;
            id = null;
        }
        private void LoadData()
        {
            DgvPatients.DataSource = _service.GetAll();
            DgvPatients.ClearSelection();
        }
        public void DeletePatient()
        {
            if (id == null)
            {
                MessageBox.Show("U should select a patient", "System");
            }
            else
            {
                DialogResult response = MessageBox.Show("U sure u want to delete this patient", "System", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    _service.Delete(id.Value);
                    Deselect();
                }
            }
        }
        private void DgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddPatients addPatients = new FrmAddPatients(_connection);
            addPatients.DgvPatients(e);
        }

        
    }
}
