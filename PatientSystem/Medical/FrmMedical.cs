using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PatientSystem.Home;
using LogicLayer;
using LogicLayer.Medical;
using PatientSystem.Login;

namespace PatientSystem.Medical
{
    public partial class FrmMedical : Form
    {
        SqlConnection _connection;
        ServiceMedical service;
        private bool Login = false;
        private object Mantenices = new object();
        public FrmMedical(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceMedical(_connection);
        }

        //Cada uno de los eventos del menu strip
        #region Menu Optiones

        private void maintenanceUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }
        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDoctor();
        }

        private void deleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDoctor();
        }
        private void MantenimientoUsers_Click(object sender, EventArgs e)
        {
            Login = true;
            Mantenices = true;
            this.Close();
        }

        private void keepingMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
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


        #endregion // Cada uno de los eventos del menu strip

        //Eventos generales de la  app, como el load, los btn, dgv...
        #region Events
        private void FrmMedical_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clucht();
        }
        private void FrmMedical_Load(object sender, EventArgs e)
        {
            loadData();           
            Deselect();
            DgvDoctor.Columns[0].Visible = false;
            DgvDoctor.Columns[6].Visible = false;
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddDoctor(); 
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteDoctor();
        }
        private void DgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvDoctor.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;
                GlobalRepositoty.Instance._filename = Convert.ToString(DgvDoctor.CurrentRow.Cells[6].Value);

                if(GlobalRepositoty.Instance._filename == "")
                {
                    PtbDoctor.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    PtbDoctor.ImageLocation = GlobalRepositoty.Instance._filename;
                    PtbDoctor.SizeMode = PictureBoxSizeMode.StretchImage;
                }             
                BtnDeselect.Visible = true;

                GlobalRepositoty.Instance.Doc = service.GetById(GlobalRepositoty.Instance.id);
            }
        }
        #endregion

        //Metodos privados para desarrollar las funciones de lo anterior.
        #region Private Metodos

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
        private void AddDoctor()
        {
            Deselect();
            FrmAddDoctor Add = new FrmAddDoctor(_connection);
            this.Hide();
            Add.Show();
        }

        private void EditDoctor()
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

        private void DeleteDoctor()
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
                        MessageBox.Show("¿A donde tan' arreglado? Este doctor ta' bregando con un paciente *clock*", "System");
                    }
                }
                else
                {
                    Deselect();
                }
            }
        }

        private void GoBackHome()
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
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
                        User.FrmUser user = new User.FrmUser(_connection);
                        user.Show();
                    }
                    else if (!(bool)Mantenices)
                    {
                        Lab.FrmLabTest test = new Lab.FrmLabTest(_connection);
                        test.Show();
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

        #endregion





    }
}
