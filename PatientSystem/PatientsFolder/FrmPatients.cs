using DataLayer.Models;
using LogicLayer;
using LogicLayer.PatientLogic;
using PatientSystem.Home;
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
        public FrmPatients(SqlConnection cn)
        {
            InitializeComponent();
            _service = new ServicePatient(cn);
            _connection = cn;
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void FrmPatients_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(GlobalRepositoty.Instance.index >= 0)
            {
                FrmAddPatients patients = new FrmAddPatients(_connection);
                patients.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("U should select a patient", "System");
            }
        }
        private void FrmPatients_Load(object sender, EventArgs e)
        {
            LoadData();            
        }
        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvPatients.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;
                GlobalRepositoty.Instance._filename = Convert.ToString(DgvPatients.CurrentRow.Cells[9].Value);

                PtbPatients.ImageLocation = GlobalRepositoty.Instance._filename;
                PtbPatients.SizeMode = PictureBoxSizeMode.StretchImage;
                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.Patient = _service.GetById(GlobalRepositoty.Instance.id);
                
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Deselect();
            FrmAddPatients frmPatients = new FrmAddPatients(_connection);
            frmPatients.Show();
            this.Hide();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        public void DeletePatient()
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("U should select a patient", "System");
            }
            else
            {
                DialogResult response = MessageBox.Show("U sure u want to delete this patient", "System", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    _service.Delete(GlobalRepositoty.Instance.id);
                    Deselect();
                    LoadData();
                }
            }
        }
        
        private void Deselect()
        {
            DgvPatients.ClearSelection();
            BtnDeselect.Visible = false;
            GlobalRepositoty.Instance.index = -1;
            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.Patient = new PatientsModel();
            PtbPatients.ImageLocation = "";
        }
        private void LoadData()
        {
            DgvPatients.DataSource = _service.GetAll();
            DgvPatients.Columns[9].Visible = false;
            DgvPatients.Columns[0].Visible = false;
            DgvPatients.ClearSelection();

        }

        
    }
}

