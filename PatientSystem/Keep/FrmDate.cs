using PatientSystem.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.Keep
{
    public partial class FrmDate : Form
    {
        public FrmDate()
        {
            InitializeComponent();
        }

        private void FrmDate_Load(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            FrmListPatients listPatients = new FrmListPatients();           
            listPatients.Show();

        }
    }
}
