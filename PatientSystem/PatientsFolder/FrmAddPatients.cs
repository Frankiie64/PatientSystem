using LogicLayer.PatientLogic;
using DataLayer.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PatientSystem;
using LogicLayer;
using System.IO;

namespace PatientSystem.Patients
{
    public partial class FrmAddPatients : Form
    {
        private ServicePatient _service;
        public int? id = null;
        SqlConnection _connection;
        public string filename = null;
        ComboBoxItem Smoker;

        public FrmAddPatients(SqlConnection cn)
        {
            InitializeComponent();
            _connection = cn;
            _service = new ServicePatient(cn);
        }
        private void FrmAddPatients_Load(object sender, EventArgs e)
        {

            LoadCbx();
        }
        private void btnSavePhoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private bool validation()
        {
            try
            {
                Smoker = CbxSmoker.SelectedItem as ComboBoxItem;
                
                if(string.IsNullOrWhiteSpace(TxbName.Text))
                {
                    MessageBox.Show("Plis introduce the patiens' name.", "System");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbLastName.Text))
                {
                    MessageBox.Show("Plis introduce the patiens' Lastname.", "System");
                    return false;
                }
                else if (!MtbPhone.MaskFull)
                {
                    MessageBox.Show("Plis introduce the patiens' phone number.", "System");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbAddress.Text))
                {
                    MessageBox.Show("Plis introduce the patiens' address.", "System");
                    return false;
                }
                else if (!MtbCard.MaskFull)
                {
                    MessageBox.Show("Plis introduce the patiens' id.", "System");
                    return false;
                }
                else if (!MtbBirth.MaskFull)
                {
                    MessageBox.Show("Plis introduce the patiens' birthday.", "System");
                    return false;
                }               
                else if (Smoker.Value == null)
                {
                    MessageBox.Show("smoker field is empty ", "System");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(TxbAllergies.Text))
                {
                    MessageBox.Show("Plis introduce the patiens' allergies.(if don't have write 'nop')", "System");
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch(Exception ex)
            {
                return false;
            }



        }
        public void AddPatient()
        {
            PatientsModel item = new PatientsModel();
            ComboBoxItem selectedSmoke = CbxSmoker.SelectedItem as ComboBoxItem;
            try
            {
                item.Fname = TxbName.Text;
                item.LastName = TxbLastName.Text;
                item.PhoneNumber = MtbPhone.Text;
                item.Address = TxbAddress.Text;
                item.Identification = MtbCard.Text;
                item.NatalDay = DateTime.ParseExact(MtbBirth.Text, "dd/MM/yyyy", null);
                item.Smoker = (int)selectedSmoke.Value;
                item.Allergies = TxbAllergies.Text;

                if (_service.Add(item))
                {
                    SavePhoto();                 
                    MessageBox.Show("The patients was saved bacanamente", "System");                   
                }
                else
                {
                    MessageBox.Show("The patients was not saved sad-mente", "System");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The patients was not saved sad-mente", "System");

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
            if (!Directory.Exists(dirrectionally))
            {
                Directory.CreateDirectory(dirrectionally);
            }
        }
        private PatientsModel paciente(ComboBoxItem smoker, ComboBoxItem nosmoker)
        {
            ComboBoxItem selectedSmoke = CbxSmoker.SelectedItem as ComboBoxItem;
            PatientsModel item = GlobalRepositoty.Instance.Patient;
            TxbName.Text = item.Fname;
            TxbLastName.Text = item.LastName;
            MtbPhone.Text = item.PhoneNumber;
            TxbAddress.Text = item.Address;
            MtbCard.Text = item.Identification;
            MtbBirth.Text = Convert.ToString(item.NatalDay);
            if (item.Smoker == 1)
            {
                CbxSmoker.SelectedItem = smoker;

            }
            else
            {
                CbxSmoker.SelectedItem = nosmoker;
            }
            TxbAllergies.Text = item.Allergies;
            PtbPatients.ImageLocation = GlobalRepositoty.Instance._filename;

            return GlobalRepositoty.Instance.Patient;
        }
        public void EditPatient()
        {
            PatientsModel item = new PatientsModel();
            ComboBoxItem selectedSmoke = CbxSmoker.SelectedItem as ComboBoxItem;
            item.Fname = TxbName.Text;
            item.LastName = TxbLastName.Text;
            item.PhoneNumber = MtbPhone.Text;
            item.Address = TxbAddress.Text;
            item.Identification = MtbCard.Text;
            item.NatalDay = DateTime.ParseExact(MtbBirth.Text, "dd/MM/yyyy", null);
            item.Smoker = (int)selectedSmoke.Value;
            item.Allergies = TxbAllergies.Text;
            item.Id = GlobalRepositoty.Instance.id;
            SavePhoto();
            if (_service.Edit(item, GlobalRepositoty.Instance.Patient.Identification))
            {
                MessageBox.Show("The patients was edited bacanamente", "System");
            }
            else
            {
                MessageBox.Show("The patients wasn't edited bacanamente", "System");

            }
        }
        public void LoadCbx()
        {
            ComboBoxItem defaultOption = new ComboBoxItem();
            {
                defaultOption.Text = "Select an option";
                defaultOption.Value = null;
            };
            ComboBoxItem yesismoke = new ComboBoxItem();
            {
                yesismoke.Text = "Yes";
                yesismoke.Value = 1;
            };
            ComboBoxItem noidontsmoke = new ComboBoxItem();
            {
                noidontsmoke.Text = "Nope";
                noidontsmoke.Value = 0;
            };

            CbxSmoker.Items.Add(defaultOption);
            CbxSmoker.Items.Add(yesismoke);
            CbxSmoker.Items.Add(noidontsmoke);
            CbxSmoker.SelectedItem = defaultOption;

            if (GlobalRepositoty.Instance.id > 0)
            {
                paciente(yesismoke, noidontsmoke);
            }
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (GlobalRepositoty.Instance.id == 0)
                {
                    AddPatient();
                }
                else
                {
                    EditPatient();
                }
                this.Close();
            }
        }
        private void FrmAddPatients_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPatients patients = new FrmPatients(_connection);
            patients.Show();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPhoto()
        {
            DialogResult result = ChosePhot.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = ChosePhot.FileName;
                PtbPatients.ImageLocation = filename;
            }
        }

    }
}

