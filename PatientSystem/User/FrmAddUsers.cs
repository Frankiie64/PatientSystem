﻿using PatientSystem.ComboBoxItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.User
{
    public partial class FrmAddUsers : Form
    {
        SqlConnection _connection;
        public FrmAddUsers(string connection)
        {
            InitializeComponent();
            _connection = new SqlConnection(connection);
        }

        #region


        private void FrmAddUsers_Load(object sender, EventArgs e)
        {
            loadUsers();            
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        #endregion

        private void AddUser()
        {
            if(string.IsNullOrWhiteSpace(TxbName.Text))
            {
                MessageBox.Show("Por favor introduzca el nombre", "Error");
            }
            else if (string.IsNullOrWhiteSpace(TxbLastName.Text))
            {
                MessageBox.Show("Por favor introduzca el apellido", "Error");
            }
            else if (string.IsNullOrWhiteSpace(TxbMail.Text))
            {
                MessageBox.Show("Por favor introduzca el correo", "Error");
            }
            else if (string.IsNullOrWhiteSpace(TxbUser.Text))
            {
                MessageBox.Show("Por favor introduzca el usuario", "Error");
            }
            else if (string.IsNullOrWhiteSpace(TxbPassword.Text) || string.IsNullOrWhiteSpace(TxbConfirm.Text))
            {
                MessageBox.Show("Por favor introduzca la contraseña", "Error");
            }
            else if (CxbType.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor introduzca el rol de la persona", "Error");

            }
            else 
            {
                MessageBox.Show("Correct", "ok");
            }

        }
        private void loadUsers()
        {
            ComboBoxItems DefaultOption = new ComboBoxItems();
            {
                DefaultOption.Text = "Seleccione una opcion";
                DefaultOption.Value = null;

            }
            ComboBoxItems Admistration = new ComboBoxItems();
            {
                Admistration.Text = "Administrator";
                Admistration.Value = 0;

            }
            ComboBoxItems Doctor = new ComboBoxItems();
            {
                Doctor.Text = "Doctor";
                Doctor.Value = 1;
            }

            CxbType.Items.Add(DefaultOption.Text);
            CxbType.Items.Add(Admistration.Text);
            CxbType.Items.Add(Doctor.Text);
            

            CxbType.SelectedItem = DefaultOption;

        }
    }
}