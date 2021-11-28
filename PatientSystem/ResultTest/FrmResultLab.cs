using LogicLayer;
using LogicLayer.LogicTestResult;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogicLayer.FolderLabTest;
using PatientSystem.Login;
namespace PatientSystem.ResultTest
{
    public partial class FrmResultLab : Form
    {
        SqlConnection _cn;
        ServiceTestResult _service;
        private bool Login = false;
        private object Mantenices = new object();
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
            ReportResult();
          
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
        private void ReportResult()
        {
            if (GlobalRepositoty.Instance.id > 0)
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
        private void Clucht()
        {
            try
            {
                if (Login)
                {
                    if (Mantenices == new object())
                    {
                        FrmLogin.Intance.Show();
                    }
                    else if ((bool)Mantenices)
                    {
                        Keep.FrmKeep keep = new Keep.FrmKeep(_cn);
                        keep.Show();
                    }
                    else if (!(bool)Mantenices)
                    {
                        Patients.FrmPatients patients = new Patients.FrmPatients(_cn);
                        patients.Show();
                    }

                }
                else
                {
                    GoBackHome();
                }
            }
            catch (Exception ex)
            {
                FrmLogin.Intance.Show();
            }
        }

        private void GoBackHome()
        {
           Home.FrmHome home = new Home.FrmHome(_cn);
            home.Show();
        }

        private void FrmResultLab_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clucht();

        }

        private void MantenimientoKeep_Click(object sender, EventArgs e)
        {
            Login = true;
            Mantenices = true;
            this.Close();
        }

        private void MantenPatinents_Click(object sender, EventArgs e)
        {
            Login = true;
            Mantenices = false;
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login = true;
            this.Close();
        }

        private void goBackHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            ReportResult();
        }
    }
}
