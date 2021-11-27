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
        #region Menu Optiones

        private void userMaintenaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainteniceUsers();
        }
        private void medicalMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainteniceDoctors();
        }
        private void laboratoyTestMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainteniceLabTest();
        }
        private void patientMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenicePatiens();
        }
        private void keepingMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainteniceKeep();
        }
        private void maintainingLaboratoryTestResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainteniceResultTest();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goBackHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U 're in Home right now", "Notification");
        }
        #endregion
        #region Mantenice
        private void BtnUser_Click(object sender, EventArgs e)
        {
            MainteniceUsers();
        }
        private void BtnMedical_Click(object sender, EventArgs e)
        {
            MainteniceDoctors();
        }
        private void BtnTestLab_Click(object sender, EventArgs e)
        {
            MainteniceLabTest();
        }
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            MaintenicePatiens();
        }
        private void BtnKeep_Click(object sender, EventArgs e)
        {
            MainteniceKeep();
        }
        private void BtnTestResult_Click(object sender, EventArgs e)
        {
            MainteniceResultTest();
        }
        #endregion
        #region Events
        private void FrmHome_Load(object sender, EventArgs e)
        {
            goBackHomeToolStripMenuItem.Visible = false;
            if(GlobalRepositoty.Instance.TyperUser == 0)
            {
                BtnKeep.Enabled = false;
                BtnPatient.Enabled = false;
                BtnTestResult.Enabled = false;
                MaintenaceAdministrator.Visible = true;

            }
            else
            {
                BtnUser.Enabled = false;
                BtnMedical.Enabled = false;
                BtnTestLab.Enabled = false;
                MenuDoctors.Visible = true;
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

        #endregion      
        #region Private Metodos
        private void MainteniceUsers()
        {
            User.FrmUser Users = new User.FrmUser(_conection);
            this.Hide();
            Users.Show();
        }

        private void MainteniceDoctors()
        {
            Medical.FrmMedical medical = new Medical.FrmMedical(_conection);
            this.Hide();
            medical.Show();
        }
        private void MainteniceLabTest()
        {
            Lab.FrmLabTest labTest = new Lab.FrmLabTest(_conection);
            this.Hide();
            labTest.Show();
        }
        private void MaintenicePatiens()
        {
            Patients.FrmPatients patients = new Patients.FrmPatients(_conection);
            this.Hide();
            patients.Show();
        }
        private void MainteniceKeep()
        {
            Keep.FrmKeep keep = new Keep.FrmKeep(_conection);
            this.Hide();
            keep.Show();
        }
        private void MainteniceResultTest()
        {
            ResultTest.FrmResultLab resultLab = new ResultTest.FrmResultLab(_conection);
            this.Hide();
            resultLab.Show();
        }




        #endregion

      
    }
}
