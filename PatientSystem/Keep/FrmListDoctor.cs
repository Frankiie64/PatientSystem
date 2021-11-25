using LogicLayer;
using LogicLayer.LogicKeep;
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
    public partial class FrmListDoctor : Form
    {
        SqlConnection _cn;
        ServiceKeep _service;
        public FrmListDoctor(SqlConnection cn)
        {
            InitializeComponent();
            _cn = cn;
            _service = new ServiceKeep(_cn);
        }
        private void FrmListDoctor_Load(object sender, EventArgs e)
        {
            LoadData();
           
        }
        private void LoadData()
        {
            DgvDoctor.DataSource = _service.GetListDoctors();
            DgvDoctor.ClearSelection();
            DgvDoctor.Columns[0].Visible = false;
            DgvDoctor.Columns[6].Visible = false;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (ValidtionNextSteph())
            {
                FrmDate date = new FrmDate(_cn);
                date.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select a Doctor, to continue.");
            }                      
        }
        private bool ValidtionNextSteph()
        {
            return GlobalRepositoty.Instance.index >= 0 ? true : false;
        }      
        private void DgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvDoctor.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;
                GlobalRepositoty.Instance.Doc = _service.GetDoctorsById(GlobalRepositoty.Instance.id);
            }
        }
        private bool validationSearch()
        {
            return (MtbCard.MaskFull);
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (validationSearch())
            {
                DgvDoctor.DataSource = _service.GetUniquePatients(MtbCard.Text);
                if (DgvDoctor.Rows.Count == 0)
                {
                    MessageBox.Show($"The id {DgvDoctor.DataSource} does not exist in the current context.Please try again :)");
                }
            }
            else
            {
                MessageBox.Show("Please, complete the form");
            }
        }
    }
}
