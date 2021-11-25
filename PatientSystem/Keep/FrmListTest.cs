using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.DataLabTest;
using LogicLayer.LogicKeep;

namespace PatientSystem.Keep
{
    public partial class FrmListTest : Form
    {
        SqlConnection _connection;
        ServiceKeep service;
        
        public FrmListTest(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceKeep(_connection);
        }

        private void FrmListTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
           DgvTest.DataSource = service.GetListTest();
           DgvTest.ClearSelection();
        }
    }
}
