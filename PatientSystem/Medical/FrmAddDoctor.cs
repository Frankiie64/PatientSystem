using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer.Medical;
using LogicLayer;
using DataLayer.Models;
namespace PatientSystem.Medical
{
    public partial class FrmAddDoctor : Form
    {
        SqlConnection _connection;
        ServiceMedical _service;
        public FrmAddDoctor(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _service = new ServiceMedical(_connection);
            Rellenar();
        }
 #region Events
        private void FrmAddDoctor_Load(object sender, EventArgs e)
        {

        }
        private void FrmAddDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedical medical = new FrmMedical(_connection);
            medical.Show();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (GlobalRepositoty.Instance.id > 0)
                {

                    if (_service.EditDoc(createDoc()))
                    {
                        MessageBox.Show("Se ha editado correctamente el usuario", "Notficacion");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Este medico ya esta registrado", "Notficacion");

                    }


                }
                else
                {
                    if (_service.AddUDoc(createDoc()))
                    {
                        MessageBox.Show("Se ha creado correctamente el usuario", "Notficacion");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Este medico ya esta registrado", "Notficacion");

                    } 
                                                          
                }
            }
        }




        #endregion
        private Doctors createDoc()
        {
            
            
                Doctors doctors = new Doctors();
                {
                    doctors.FName = TxbName.Text;
                    doctors.LastName = TxbLastName.Text;
                    doctors.Email = TxbMail.Text;
                    doctors.PhoneNumber = MtbPhone.Text;
                    doctors.Identification = MtbCard.Text;

                }
                return doctors;
            
        }

        private bool validation()
        {
            if(string.IsNullOrWhiteSpace(TxbName.Text))
            {
                MessageBox.Show("Introduca el nombre del medico", "Error");
                    return false; 
            }
            else if (string.IsNullOrWhiteSpace(TxbLastName.Text))
            {
                MessageBox.Show("Introduca el apellido del medico", "Error");
                return false; 

            }
            else if (string.IsNullOrWhiteSpace(TxbMail.Text))
            {
                MessageBox.Show("Introduca el correo del medico", "Error");
                return false; 

            }
            else if (MtbPhone.MaskFull == false)
            {
                MessageBox.Show("Complete el numero de telefono del medico", "Error");
                return false; 

            }
            else if (MtbCard.MaskFull == false)
            {
                MessageBox.Show("Complete la identificacion del medico", "Error");
                return false; 
            }
            else 
            {
                return true;
            }

        }
        private void Rellenar()
        {
            if(GlobalRepositoty.Instance.id > 0)
            { 
                TxbName.Text = GlobalRepositoty.Instance.Doc.FName;
                TxbLastName.Text = GlobalRepositoty.Instance.Doc.LastName;
                TxbMail.Text = GlobalRepositoty.Instance.Doc.Email;
                MtbPhone.Text = GlobalRepositoty.Instance.Doc.PhoneNumber;
                MtbCard.Text  = GlobalRepositoty.Instance.Doc.Identification;
            }
        }

        

    }
}
