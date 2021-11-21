using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer;
using PatientSystem;


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

        #region


        private void BtnUser_Click(object sender, EventArgs e)
        {
            User.FrmUser Users = new User.FrmUser(_conection);
            this.Close();
            Users.Show();
        }

        private void BtnMedical_Click(object sender, EventArgs e)
        {
           Medical.FrmMedical medical = new Medical.FrmMedical(_conection);
            this.Close();
            medical.Show();
        }

        private void BtnTestLab_Click(object sender, EventArgs e)
        {
            Lab.FrmLabTest labTest = new Lab.FrmLabTest(_conection);
            this.Close();
            labTest.Show();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            Patients.FrmPatients patients = new Patients.FrmPatients();
            this.Close();
            patients.Show();
        }

        private void BtnKeep_Click(object sender, EventArgs e)
        {
            Keep.FrmKeep keep = new Keep.FrmKeep();
            this.Close();
            keep.Show();
        }

        private void BtnTestResult_Click(object sender, EventArgs e)
        {

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
    }
}
