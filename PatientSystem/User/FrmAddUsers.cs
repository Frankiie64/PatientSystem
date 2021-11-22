using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientSystem;
using LogicLayer.Usuario;
using DataLayer.Models;
using LogicLayer;
using System.Text.RegularExpressions;

namespace PatientSystem.User
{

    public partial class FrmAddUsers : Form
    {
        ComboBoxItem rol;
        SqlConnection _connection;
        ServiceUsers _service;
       
        public FrmAddUsers(string connection)
        {
            InitializeComponent();
            _connection = new SqlConnection(connection);
            _service = new ServiceUsers(_connection);
            
        }

        #region
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUser frmUser = new FrmUser(_connection);
            frmUser.Show();
        }
        private void Edit(Users item,int id,ComboBoxItem Adm,ComboBoxItem Doc)
        {
            if (id >= 1)
            {
                ComboBoxItem Usuario = CxbType.SelectedItem as ComboBoxItem;
                TxbName.Text = item.FName;
                TxbLastName.Text = item.LastName;
                TxbMail.Text = item.LastName;
                TxbUser.Text = item.NickName;
                TxbPassword.Text = item.Pass;
                TxbConfirm.Text = item.Pass;
                if(item.TypeUsers == 0)
                {
                    CxbType.SelectedItem = Adm;

                }
                else
                {
                    CxbType.SelectedItem = Doc;
                }

            }
        }
        private void FrmAddUsers_Load(object sender, EventArgs e)
        {
            loadUsers();            
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            if(validation() == true)
            {
                if(GlobalRepositoty.Instance.id > 0)
                {
                   if( _service.EditUser(CreateUse(),GlobalRepositoty.Instance.Usuario.NickName))
                    {
                        MessageBox.Show("Se ha editado correctamente", "Edicion correcta");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("El usuario que intenta registrar ya existe", "Error");

                    }

                }
                else
                { 
                    AddUser();
                                      
                }
            }
        }
        #endregion


        private bool validation()
        {
            rol = CxbType.SelectedItem as ComboBoxItem;

            try
            {
                if (string.IsNullOrWhiteSpace(TxbName.Text))
                {
                    MessageBox.Show("Por favor introduzca el nombre", "Error");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbLastName.Text))
                {
                    MessageBox.Show("Por favor introduzca el apellido", "Error");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbMail.Text))
                {
                    MessageBox.Show("Por favor introduzca el correo", "Error");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbUser.Text))
                {
                    MessageBox.Show("Por favor introduzca el usuario", "Error");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbPassword.Text) || string.IsNullOrWhiteSpace(TxbConfirm.Text))
                {
                    MessageBox.Show("Por favor introduzca la contraseña", "Error");
                    return false;
                }
                else if (rol.Value == null)
                {
                    MessageBox.Show("Por favor introduzca el rol de la persona", "Error");
                    return false;
                }
                else if (ValidationEmail(TxbMail.Text) == false)
                {
                    MessageBox.Show("El email que desea de ingresar no corresponde a una dirrecion de correo reconocidad por el sistema, favor tratar de nuevo.", "Error");
                    return false;
                }
                else
                        {
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Error", "Error");
                return false;
            }
        }

        private Users CreateUse()
        {
            Users item = new Users();
            {
                item.FName = TxbName.Text;
                item.LastName = TxbLastName.Text;
                item.Email = TxbMail.Text;
                item.NickName = TxbUser.Text;
                item.TypeUsers = Convert.ToInt32(rol.Value);
                item.Pass = TxbPassword.Text;                
            }
            return item;
        }
        private void AddUser()
        {
                           
                if (_service.AddUser(CreateUse()) == 1)
                {
                    MessageBox.Show("Se ha creado correctamente el usuario", "Notficacion");
                    this.Close();
                }
                else if (_service.AddUser(CreateUse()) == 2)
                {
                MessageBox.Show("Este usuario ya esta registrado", "Notficacion");

                }
                else if (_service.AddUser(CreateUse()) == 3)
                {
                MessageBox.Show("Ha ocurrido un problema con el correo", "Notficacion");

                }
                 else if (_service.AddUser(CreateUse()) == 4)
                {
                MessageBox.Show("Error desconocido", "Notficacion");

                }

        }
        private void loadUsers()
        {
            ComboBoxItem DefaultOption = new ComboBoxItem();
            {
                DefaultOption.Text = "Seleccione una opcion";
                DefaultOption.Value = null;

            }
            ComboBoxItem Admistration = new ComboBoxItem();
            {
                Admistration.Text = "Administrator";
                Admistration.Value = 0;

            }
            ComboBoxItem Doctor = new ComboBoxItem();
            {
                Doctor.Text = "Doctor";
                Doctor.Value = 1;
            }

            CxbType.Items.Add(DefaultOption);
            CxbType.Items.Add(Admistration);
            CxbType.Items.Add(Doctor);

            CxbType.SelectedItem = DefaultOption;
            Edit(GlobalRepositoty.Instance.Usuario, GlobalRepositoty.Instance.id, Admistration, Doctor);
        }
        private Boolean ValidationEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
