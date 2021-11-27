using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer.LogicKeep;
using LogicLayer;

namespace PatientSystem.Keep
{
    public partial class FrmSeeResult : Form
    {
        SqlConnection _connection;
        ServiceKeep service;
        
        public FrmSeeResult(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceKeep(_connection);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeeResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmKeep keep = new FrmKeep(_connection);
            keep.Show();
        }

        private void FrmSeeResult_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DgvLabResult.DataSource = service.GetFinaltResult(GlobalRepositoty.Instance.appointment.Id);
            DgvLabResult.ClearSelection();
        }
    }
}
