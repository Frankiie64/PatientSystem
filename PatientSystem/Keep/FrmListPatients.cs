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
        #region Events
        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (validationSearch())
            {
                DgvPatients.DataSource = _service.GetUniquePatients(MtbCard.Text);
                BtnDeselect.Visible = true;
                if(DgvPatients.Rows.Count == 0)
                {
                    MessageBox.Show("the id you try to find does not exist in the data base");
                    Deselect();
                }
            }
            else
            {
                MessageBox.Show("Please, complete the form");
            }
        }
        private void FrmListPatients_Load(object sender, EventArgs e)
        {
            Loadata();
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(ValidtionNextSteph())
            {
                this.Close();
                FrmListDoctor listDoctors = new FrmListDoctor(_cn);
                listDoctors.Show();
            }
            else
            {
                MessageBox.Show("Select a patients, to continue.");
            }           
        }      
        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvPatients.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.Patient = _service.GetPatientsById(GlobalRepositoty.Instance.id);

            }
        }
        #endregion
        #region Metodos Private
        private bool ValidtionNextSteph()
        {
            return GlobalRepositoty.Instance.index >= 0 ? true : false;
        }
        private void Deselect()
        {
            MtbCard.Clear();
            DgvPatients.ClearSelection();
            BtnDeselect.Visible = false;
            Loadata();

            GlobalRepositoty.Instance.index = -1;
            GlobalRepositoty.Instance.Patient = new DataLayer.Models.PatientsModel();
        }
        private void Loadata()
        {          
            DgvPatients.DataSource = _service.GetListPatients();
            DgvPatients.ClearSelection();
            DgvPatients.Columns[0].Visible = false;
            DgvPatients.Columns[9].Visible = false;           
        }
        private bool validationSearch()
        {
            return (MtbCard.MaskFull);
        }
        #endregion
      
    }
}
