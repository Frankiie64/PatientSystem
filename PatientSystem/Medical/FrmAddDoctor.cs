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
using EmailLayer;
using System.Text.RegularExpressions;
using System.IO;

namespace PatientSystem.Medical
{
    public partial class FrmAddDoctor : Form
    {
        SqlConnection _connection;
        ServiceMedical _service;
        public string filename = null;
              
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
        private void btnSavePhoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
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

                    if (_service.EditDoc(createDoc(), GlobalRepositoty.Instance.Doc.Identification))
                    {
                        MessageBox.Show("Se ha editado correctamente el usuario", "Notficacion");
                        if (!SavePhoto())
                        {
                            MessageBox.Show("Uhy error de subida en la foto.");
                        };
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este medico ya esta registrado", "Notficacion");
                    }
                }
                else
                {
                    if (_service.AddUDoc(createDoc()) == 1)
                    {
                        MessageBox.Show("Se ha creado correctamente el doctor", "Notficacion");
                        SavePhoto();
                        this.Close();
                    }
                    else if (_service.AddUDoc(createDoc()) == 2)
                    {
                        MessageBox.Show("Este medico ya esta registrado", "Notficacion");

                    }
                    else if (_service.AddUDoc(createDoc()) == 3)
                    {
                        MessageBox.Show("Ha ocurrido un problema con el correo", "Notficacion");

                    }
                    else if (_service.AddUDoc(createDoc()) == 4)
                    {
                        MessageBox.Show("Error desconocido", "Notficacion");

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
        private void AddPhoto()
        {
            DialogResult result = DialogDoctor.ShowDialog();

            if (result ==  DialogResult.OK)
            {
                filename = DialogDoctor.FileName;
                PtbImage.ImageLocation = filename;
            }            
        }
        private bool SavePhoto()
        {
            try
            {
                int LastId = GlobalRepositoty.Instance.id != 0 ? GlobalRepositoty.Instance.id : _service.GetLastId();
                if (!string.IsNullOrWhiteSpace(filename))
                {
                    string dirrectionally = @"Imagenes\Doctors\" + LastId + "\\";
                    CreateDirecotry(dirrectionally);

                    string[] fileNameSplit = filename.Split("\\");
                    string _filename = fileNameSplit[(fileNameSplit.Length - 1)];

                    string location = dirrectionally + _filename;

                    File.Copy(filename, location, true);

                    _service.SavePhoto(LastId, location);

                    return true;
                }
                return false;
            }            
            catch
            {
                return false;
            }
        }
        private void CreateDirecotry(string dirrectionally)
        {
            if(!Directory.Exists(dirrectionally))
            {
                Directory.CreateDirectory(dirrectionally);
            }
        }
        private bool validation()
        {
            if (string.IsNullOrWhiteSpace(TxbName.Text))
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
        private void Rellenar()
        {
            if (GlobalRepositoty.Instance.id > 0)
            {
                TxbName.Text = GlobalRepositoty.Instance.Doc.FName;
                TxbLastName.Text = GlobalRepositoty.Instance.Doc.LastName;
                TxbMail.Text = GlobalRepositoty.Instance.Doc.Email;
                MtbPhone.Text = GlobalRepositoty.Instance.Doc.PhoneNumber;
                MtbCard.Text = GlobalRepositoty.Instance.Doc.Identification;
                PtbImage.ImageLocation = GlobalRepositoty.Instance._filename;
            }
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
