using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.Models;
using LogicLayer;
using LogicLayer.Usuario;
using PatientSystem.Login;
using PatientSystem.Home;


namespace PatientSystem.User
{
    public partial class FrmUser : Form
    {
        SqlConnection _connection;
        ServiceUsers _service;       
        public FrmUser(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _service = new ServiceUsers(_connection);

        }

        #region Events
        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome home = new FrmHome(_connection);
            home.Show();
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            loadData();
            Deselect();
        }
        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GlobalRepositoty.Instance.id = Convert.ToInt32(DgvUser.CurrentRow.Cells[0].Value);
                GlobalRepositoty.Instance.index = e.RowIndex;

                BtnDeselect.Visible = true;
             
                GlobalRepositoty.Instance.Usuario = _service.GetById(GlobalRepositoty.Instance.id);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalRepositoty.Instance.index < 0)
            {
                MessageBox.Show("Por favor seleccione el usario que desea Editar", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar este usuario ?", "QUESTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (_service.DeleteUser(GlobalRepositoty.Instance.id))
                    {
                        MessageBox.Show("Se ha eliminado correctamente", "Eliminacion del usario");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error");
                        loadData();
                    }
                }
                else
                {
                    Deselect();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Deselect();
            FrmAddUsers Add = new FrmAddUsers(FrmLogin.Intance.connectionString);            
            this.Hide();            
            Add.Show();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmAddUsers Edit = new FrmAddUsers(FrmLogin.Intance.connectionString);
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

        #endregion

        
        public void loadData()
        {

            DgvUser.DataSource = _service.LoadTable();
            DgvUser.ClearSelection();
        }
        public void Deselect()
        {
            DgvUser.ClearSelection();
            BtnDeselect.Visible = false;
            GlobalRepositoty.Instance.index = -1;
            GlobalRepositoty.Instance.id = new int();
            GlobalRepositoty.Instance.Usuario = new Users();
            
        }

       
    }


}

