using DataLayer.Models;
using LogicLayer;
using LogicLayer.PatientLogic;
using PatientSystem.Home;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PatientSystem.Login;

namespace PatientSystem.Patients
{
    public partial class FrmPatients : Form
    {
        private ServicePatient _service;
        private SqlConnection _connection;
        private bool Login = false;
        private object Mantenices = new object();
        public FrmPatients(SqlConnection cn)
        {
            InitializeComponent();
            _service = new ServicePatient(cn);
            _connection = cn;
        }

        #region Menu Strip

        private void MantenimientoKeep_Click(object sender, EventArgs e)
        {
            Login = true;
            Mantenices = true;
            this.Close();
        }

        private void MantenimientoLabResult_Click(object sender, EventArgs e)
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

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            AddPatients();
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            EditPatients();
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

        #endregion

        #region Events

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void FrmPatients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clucht();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditPatients();
        }
        private void FrmPatients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPatients();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }
        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvPatients.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;
                GlobalRepositoty.Instance._filename = Convert.ToString(DgvPatients.CurrentRow.Cells[9].Value);

                if (GlobalRepositoty.Instance._filename == "")
                {
                    PtbPatients.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    PtbPatients.ImageLocation = GlobalRepositoty.Instance._filename;
                    PtbPatients.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.Patient = _service.GetById(GlobalRepositoty.Instance.id);

            }

        }

        #endregion

        #region Private metodos
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
                    if (_service.Delete(GlobalRepositoty.Instance.id))
                    {
                        Deselect();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Profesor, usted no es tiguere. Ese paciente esta bajo consulta", "System");
                        Deselect();
                    }
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
                        Keep.FrmKeep keep = new Keep.FrmKeep(_connection);
                        keep.Show();
                    }
                    else if (!(bool)Mantenices)
                    {
                        ResultTest.FrmResultLab result = new ResultTest.FrmResultLab(_connection);
                        result.Show();
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
        private void AddPatients()
        {
            Deselect();
            FrmAddPatients frmPatients = new FrmAddPatients(_connection);
            frmPatients.Show();
            this.Hide();
        }
        private void EditPatients()
        {
            if (GlobalRepositoty.Instance.index >= 0)
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
        #endregion
    }
}

