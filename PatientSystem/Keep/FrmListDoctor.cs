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
    public partial class FrmListDoctor : Form
    {
        SqlConnection _connection;
        ServiceKeep service;
        public FrmListDoctor(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceKeep(_connection);
        }

        private void FrmListDoctor_Load(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDate date = new FrmDate(_connection);
            date.Show();
        }
    }
}
