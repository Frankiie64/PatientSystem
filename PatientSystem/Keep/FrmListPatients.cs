using LogicLayer;
using LogicLayer.LogicKeep;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientSystem.Keep
{
    public partial class FrmListPatients : Form
    {
        ServiceKeep _service;
        SqlConnection _cn;
        public FrmListPatients(SqlConnection cn)
        {
            InitializeComponent();
            _cn = cn;
            _service = new ServiceKeep(_cn);
        }

        private void FrmListPatients_Load(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListDoctor listDoctors = new FrmListDoctor();
            listDoctors.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MtbCard.MaskFull = true ? _service.GetListPantients(MtbCard.Text) : MessageBox.Show("Please, complete the form");
            MtbCard.Text = MtbCard.MaskFull ? "true" : "false");
            
        }

        private void DgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
