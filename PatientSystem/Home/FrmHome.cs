using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogicLayer;
using PatientSystem.Login;

namespace PatientSystem.Home
{
    public partial class FrmHome : Form
    {
        SqlConnection _conection;
        public FrmHome(SqlConnection connection)
        {
            InitializeComponent();
            _conection = connection;
        }
        #region Mantenice
        private void BtnUser_Click(object sender, EventArgs e)
        {
            User.FrmUser Users = new User.FrmUser(_conection);
            this.Hide();
            Users.Show();
        }
        private void BtnMedical_Click(object sender, EventArgs e)
        {
           Medical.FrmMedical medical = new Medical.FrmMedical(_conection);
            this.Hide();
            medical.Show();
        }
        private void BtnTestLab_Click(object sender, EventArgs e)
        {
            Lab.FrmLabTest labTest = new Lab.FrmLabTest(_conection);
            this.Hide();
            labTest.Show();
        }
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            Patients.FrmPatients patients = new Patients.FrmPatients(_conection);
            this.Hide();
            patients.Show();
        }
        private void BtnKeep_Click(object sender, EventArgs e)
        {
            Keep.FrmKeep keep = new Keep.FrmKeep(_conection);
            this.Hide();
            keep.Show();
        }
        private void BtnTestResult_Click(object sender, EventArgs e)
        {
            ResultTest.FrmResultLab resultLab = new ResultTest.FrmResultLab(_conection);
            this.Hide();
            resultLab.Show();
        }   
        #endregion 
        private void FrmHome_Load(object sender, EventArgs e)
        {
            if(GlobalRepositoty.Instance.TyperUser == 0)
            {
                BtnKeep.Enabled = false;
                BtnPatient.Enabled = false;
                BtnTestResult.Enabled = false;
            }
            else
            {
                BtnUser.Enabled = false;
                BtnMedical.Enabled = false;
                BtnTestLab.Enabled = false;
            }
        }
        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Intance.Show();
        }
        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
