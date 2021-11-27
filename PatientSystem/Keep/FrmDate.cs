using DataLayer.Models;
using LogicLayer;
using LogicLayer.LogicKeep;
using PatientSystem.Home;
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
        SqlConnection _cn;
        ServiceKeep _service;
        public bool validate = true;
        public FrmDate(SqlConnection cn)
        {
            InitializeComponent();
            _cn = cn;
            _service = new ServiceKeep(_cn);
        }

        private void FrmDate_Load(object sender, EventArgs e)
        {
            TxbPatient.Text = GlobalRepositoty.Instance.Patient.Fname;
            TxbDoctorName.Text = GlobalRepositoty.Instance.Doc.FName;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    Appointment item = new Appointment();

                    item.Id_Patients = GlobalRepositoty.Instance.Patient.Id;
                    item.Id_Doctor = GlobalRepositoty.Instance.Doc.Id;
                    item.Date_Appointment = Convert.ToDateTime($"{MtbDate.Text} {MtbHour.Text}");
                    item.StatusAppointment = 1;
                    item.Cause = TxbReason.Text;

                    if (_service.AddApointment(item))
                    {
                        MessageBox.Show("The appointmet was create sucessfull", "Notification");
                        validate = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The appointmet wasn't create sucessfull", "Notification");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void FrmDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("We'll go to the keep menu", "System");
            FrmKeep Apoint = new FrmKeep(_cn);
            Apoint.Show();
        }

        private bool Validation()
        {
            DateTime dt;
            if (!DateTime.TryParse(MtbDate.Text, out dt))
            {
                MessageBox.Show("Por favor introduzca una fecha que petenerzca al calendiario romano.", "ERROR");
                return false;
            }
            else if (!DateTime.TryParse(MtbHour.Text, out dt))
            {
                MessageBox.Show("Por favor introduzca una del formato que petenerzca al 24H.", "ERROR");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TxbReason.Text))
            { 
                MessageBox.Show("the cause box is empty. Please, especify the cause.", "ERROR");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FrmDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validate)
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
    }
}
