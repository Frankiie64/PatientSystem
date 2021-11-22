using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientSystem.Home;
using LogicLayer;
using LogicLayer.Medical;

namespace PatientSystem.Medical
{
    public partial class FrmMedical : Form
    {
        SqlConnection _connection;
        ServiceMedical service;
        public FrmMedical(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceMedical(_connection);
        }

        #region Events
        private void FrmMedical_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
        }
        private void FrmMedical_Load(object sender, EventArgs e)
        {
            loadData();
            DgvDoctor.Columns[0].Visible = false;
            DgvDoctor.Columns[6].Visible = false;
            Deselect();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Deselect();
            FrmAddDoctor Add = new FrmAddDoctor(_connection);
            this.Hide();
            Add.Show();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmAddDoctor Edit = new FrmAddDoctor(_connection);
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Editar", "Error");
            }
            else
            {
                this.Hide();
                Edit.Show();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Eliminar", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar este usuario ?", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (service.DeleteDoc(GlobalRepositoty.Instance.id))
                    {
                        MessageBox.Show("Se ha eliminado correctamente", "Eliminacion del usario");
                        loadData();
                        Deselect();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error");
                        loadData();
                        Deselect();
                    }
                }
                else
                {
                    Deselect();
                }
            }
        }
        private void DgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvDoctor.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;
                GlobalRepositoty.Instance._filename = Convert.ToString(DgvDoctor.CurrentRow.Cells[6].Value);

                PtbDoctor.ImageLocation = GlobalRepositoty.Instance._filename;
                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.Doc = service.GetById(GlobalRepositoty.Instance.id);
            }
        }
        #endregion


        public void loadData()
        {

            DgvDoctor.DataSource = service.LoadTable();
            DgvDoctor.ClearSelection();
        }
        public void Deselect()
        {
            DgvDoctor.ClearSelection();
            BtnDeselect.Visible = false;
            GlobalRepositoty.Instance.index = -1;
            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.Doc = new DataLayer.Models.Doctors();
            PtbDoctor.ImageLocation = "";

        }

        
    }
}
