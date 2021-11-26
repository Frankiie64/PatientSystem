using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer.LogicTestResult;
using DataLayer.Models;

namespace PatientSystem.ResultTest
{
    public partial class FrmReport : Form
    {
        SqlConnection _connection;
        ServiceTestResult _service;
        public FrmReport(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _service = new ServiceTestResult(_connection);
        }

        #region Events

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if(ValidationResult())
            {
                //_service.AddResult();
            }
        }

        #endregion
        #region Methodos Privates

        private bool ValidationResult()
        {
            return string.IsNullOrWhiteSpace(TxbResult.Text);
        }

       
        #endregion

    }
}
