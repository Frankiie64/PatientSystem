using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.DataLabTest;
using LogicLayer.FolderLabTest;
using DataLayer.Models;
using LogicLayer;

namespace PatientSystem.Lab
{
    public partial class FrmAddTest : Form
    {
        SqlConnection _connection;
        ServiceLabTest service;

        public FrmAddTest(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            service = new ServiceLabTest(_connection);

        }
        private void FrmAddTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLabTest Test = new FrmLabTest(_connection);
            Test.Show();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddTest_Load(object sender, EventArgs e)
        {
            if (GlobalRepositoty.Instance.id > 0)
            {

                TxbName.Text = GlobalRepositoty.Instance.test.Titles;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (GlobalRepositoty.Instance.id > 0)
                {
                    if (service.Edit(CreateTest()))
                    {
                        MessageBox.Show("Se ha editado correctamente la prueba", "Notificacion");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Esta prueba ya existe.", "Notificacion");

                    }
                }
                else
                {
                    if(service.Add(CreateTest()))
                    {
                        MessageBox.Show("Se ha creado correctamente la prueba", "Notificacion");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Esta prueba ya existe.", "Notificacion");
                        
                    }
                }
            }          
        }
        private bool validation()
        {
            if(string.IsNullOrWhiteSpace(TxbName.Text))
            {
                MessageBox.Show("Por favor introduzca el nombre de la prueba", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        private LabTest CreateTest()
        {
            LabTest test = new LabTest();
            {
                test.Titles = TxbName.Text;
            }
            return test;
        }

       
    }
}
