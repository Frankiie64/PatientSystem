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
            Appointment item = new Appointment();
            try
            {
                item.Id = GlobalRepositoty.Instance.id;
                item.Id_Patients = GlobalRepositoty.Instance.Patient.Id;
                item.Id_Doctor = GlobalRepositoty.Instance.Doc.Id;
                item.Date_Appointment = Convert.ToDateTime(MtbDate.Text);
                item.StatusAppointment = GlobalRepositoty.Instance.appointment.StatusAppointment;
                item.Cause = TxbReason.Text;

                _service.AddApointment(item);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("The Appointment was not saved :/", "System");
            }
        }

        private void FrmDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("We'll go to the principal menu", "System");
            FrmHome home = new FrmHome(_cn);
            home.Show();
        }
    }
}
