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
                else
                {
                    DgvPatients.Rows[0].Selected = true;
                    GlobalRepositoty.Instance.id = Convert.ToInt32(DgvPatients.CurrentRow.Cells[0].Value);

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
                GlobalRepositoty.Instance.Patient = _service.GetPatientsById(GlobalRepositoty.Instance.id);
                Deselect();
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

                BtnDeselect.Visible = true;
            }
        }
        #endregion
        #region Metodos Private
        private bool ValidtionNextSteph()
        {
            return GlobalRepositoty.Instance.id > 0 ? true : false;
        }
        private void Deselect()
        {
            MtbCard.Clear();
            DgvPatients.ClearSelection();
            BtnDeselect.Visible = false;
            Loadata();

            GlobalRepositoty.Instance.id = new int();
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
