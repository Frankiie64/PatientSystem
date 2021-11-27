using LogicLayer.LogicKeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer;

namespace PatientSystem.Keep
{
    public partial class FRMResultLab : Form
    {
        SqlConnection _cn;
        ServiceKeep service;

        public FRMResultLab(SqlConnection cn)
        {
            InitializeComponent();
            _cn = cn;
            service = new ServiceKeep(_cn);
        }

        private void FRMResultLab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DgvLabResult.DataSource = service.GetListResult(GlobalRepositoty.Instance.appointment.Id);
            DgvLabResult.ClearSelection();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMResultLab_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmKeep keep = new FrmKeep(_cn);
            keep.Show();
        }

        private void BtnCompleteDate_Click(object sender, EventArgs e)
        {
            if(UpdateAppointment(GlobalRepositoty.Instance.appointment.Id))
            {
                MessageBox.Show("Se ha completado la cita", "Notification");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha completado la cita", "Notification");
            }
        }
        private bool UpdateAppointment(int id)
        {
            return service.UpdateKeep(id);
        }
    }
}
