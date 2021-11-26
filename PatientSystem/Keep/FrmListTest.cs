﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.DataLabTest;
using DataLayer.Models;
using LogicLayer;
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

        private void DgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvTest.CurrentRow.Cells[0].Value);              
            }
        }
        public void AddResult()
        {
            LabResult item = new LabResult();
            try
            {
                item.Id_Patients = GlobalRepositoty.Instance.appointment.Id_Patients;
                item.Id_Doctor = GlobalRepositoty.Instance.appointment.Id_Doctor;
                item.Id_Appointment = GlobalRepositoty.Instance.appointment.Id;
                item.Id_LabTest = GlobalRepositoty.Instance.id;

                service.AddResult(item);
            }
            catch (Exception)
            {
                MessageBox.Show("The patients was not saved sad-mente", "System");
            }
        }
        private void BtnSelected_Click(object sender, EventArgs e)
        {
            AddResult();
        }
    }
}
