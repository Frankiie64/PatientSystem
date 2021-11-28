using System;
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
        private bool Decision = true;
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
           DgvTest.Columns[0].Visible = false;
        }

        private void DgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDeselected.Enabled = true;
                BtnSelected.Enabled = true;
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvTest.CurrentRow.Cells[0].Value);              
            }
        }
        public bool AddResult()
        {
            LabResult item = new LabResult();
            try
            {
                item.Id_Patients = GlobalRepositoty.Instance.appointment.Id_Patients;
                item.Id_Doctor = GlobalRepositoty.Instance.appointment.Id_Doctor;
                item.Id_Appointment = GlobalRepositoty.Instance.appointment.Id;
                item.Id_LabTest = GlobalRepositoty.Instance.id;

                return service.AddResult(item);
            }
            catch (Exception)
            {
              
                return false;
            }
        }
        private void BtnSelected_Click(object sender, EventArgs e)
        {
            ValidationResult();
        }

        private void ValidationResult()
        {
            if(AddResult())
            {
                MessageBox.Show("The tests have been correctly added to the result list.", "Notification");
                if(MessageBox.Show("Are u want to save another Test?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Decision = false;
                    this.Close();
                }
                Deselect();
            }
            else
            {
                MessageBox.Show("The tests could not be added to the result list.", "Notification");
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (validationSearch())
            {
                DgvTest.DataSource = service.GetByNameTest(TxtTestName.Text);
                btnDeselected.Enabled = true;
                if (DgvTest.Rows.Count == 0)
                {
                    MessageBox.Show("the id you try to find does not exist in the data base");
                    Deselect();
                }
                else
                {
                    DgvTest.Rows[0].Selected = true;
                    GlobalRepositoty.Instance.id = Convert.ToInt32(DgvTest.CurrentRow.Cells[0].Value);
                    BtnSelected.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Please, complete the form");
            }
        }
        private bool validationSearch()
        {
            return !(string.IsNullOrWhiteSpace(TxtTestName.Text));
        }
        private void Deselect()
        {
            TxtTestName.Clear();
            DgvTest.ClearSelection();
            btnDeselected.Enabled = false;
            BtnSelected.Enabled = false;
            LoadData();

            GlobalRepositoty.Instance.id = new int();
        }

        private void FrmListTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmKeep keep = new FrmKeep(_connection);
            keep.Show();
        }

        private void FrmListTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Decision)
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
        }

        private void btnDeselected_Click(object sender, EventArgs e)
        {
            Deselect();
        }
    }
}
