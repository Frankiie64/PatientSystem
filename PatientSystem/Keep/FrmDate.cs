using LogicLayer;
using LogicLayer.LogicKeep;
using PatientSystem.Patients;
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
    public partial class FrmDate : Form
    {
        SqlConnection _connection;
        ServiceKeep service;
        public FrmDate(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceKeep(_connection);
        }

        private void FrmDate_Load(object sender, EventArgs e)
        {
            TxbPatient.Text = GlobalRepositoty.Instance.Patient.Fname;
            // hazlo mismo con el doctor
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
           //tienes que llamar al service para guarda el appitment

        }
    }
}
