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
using LogicLayer;

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
            if(!string.IsNullOrWhiteSpace(TxbResult.Text))
            {
                if(_service.AddResult(CreateReport(),CreateReport().Id))
                {
                    MessageBox.Show("The result was insert correctly", "Notification");
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("The result wasn't inserted sucessfully ", "Notification");
                }

            }
            else
            {
                MessageBox.Show("Insert the result in the textbox before to continue.", "WARNIGN");
            }
        }

        #endregion
        #region Methodos Privates

        private LabResult CreateReport()
        {

            LabResult result = _service.GetById(GlobalRepositoty.Instance.id);
            result.TestResult = TxbResult.Text;
         
            return result;
        }
      


        #endregion

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmResultLab resultLab = new FrmResultLab(_connection);
            resultLab.Show();

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }
    }
}
