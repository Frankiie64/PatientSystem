using LogicLayer;
using LogicLayer.LogicTestResult;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogicLayer.FolderLabTest;
namespace PatientSystem.ResultTest
{
    public partial class FrmResultLab : Form
    {
        SqlConnection _cn;
        ServiceTestResult _service;
        public FrmResultLab(SqlConnection cn)
        {
            InitializeComponent();
            _cn = cn;
            _service = new ServiceTestResult(_cn);
        }


        #region Events

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(ValidationSearch())
            {
                DgvResultLab.DataSource = _service.GetResultByIdent(MtbCard.Text);
                BtnDeselect.Visible = true;
                if (DgvResultLab.Rows.Count == 0)
                {
                    MessageBox.Show("the id you try to find does not exist in the data base");
                    Deselect();
                }
                else
                {
                    DgvResultLab.Rows[0].Selected = true;
                    GlobalRepositoty.Instance.id = Convert.ToInt32(DgvResultLab.CurrentRow.Cells[0].Value);

                }
            }
            else
            {
                MessageBox.Show("Complete de id", "WARNING");

            }
        }

        #endregion

        private bool ValidationSearch()
        {
            return (MtbCard.MaskFull);
        }
       
        private void FrmResultLab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        
        private void LoadData()
        {
            DgvResultLab.DataSource = _service.GetList();
            DgvResultLab.ClearSelection();

            DgvResultLab.Columns[0].Visible = false;

        }

        public void Deselect()
        {
            DgvResultLab.ClearSelection();
            BtnDeselect.Visible = false;

            GlobalRepositoty.Instance.result = new DataLayer.Models.LabResult();
            GlobalRepositoty.Instance.id = new int();

            LoadData();

        }



        private void BtnReport_Click_1(object sender, EventArgs e)
        {
            if(GlobalRepositoty.Instance.id > 0)
            {
                FrmReport report = new FrmReport(_cn);
                this.Hide();
                report.Show();
            }
            else
            {
                MessageBox.Show("Selected a result to declared a report.");
            }
          
        }

        private void BtnDeselect_Click_1(object sender, EventArgs e)
        {
            Deselect();

        }

        private void DgvResultLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvResultLab.CurrentRow.Cells[0].Value);

                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.result = _service.GetById(GlobalRepositoty.Instance.id);
            }
        }

        private void FrmResultLab_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientSystem.Home.FrmHome home = new Home.FrmHome(_cn);
            Deselect();
            home.Show();

        }
    }
}
