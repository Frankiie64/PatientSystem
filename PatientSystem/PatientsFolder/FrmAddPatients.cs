using LogicLayer.PatientLogic;
using DataLayer.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PatientSystem;

namespace PatientSystem.Patients
{
    public partial class FrmAddPatients : Form
    {

        private ServicePatient _service;
        public int? id = null;
        SqlConnection _connection;
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

        public void AddPatient()
        {
            PatientsModel item = new PatientsModel();
            ComboBoxItem selectedSmoke = CbxSmoker.SelectedItem as ComboBoxItem;           
            item.Fname = TxbName.Text;
            item.LastName = TxbLastName.Text;
            item.PhoneNumber = MtbPhone.Text;
            item.Address = TxbAddress.Text;
            item.Identification = MtbCard.Text;
            item.NatalDay = MtbBirth.Text;
            item.Smoker = (int)selectedSmoke.Value;
            item.Allergies = TxbAllergies.Text;

            _service.Add(item);
            MessageBox.Show("The patients was saved bacanamente", "System");
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
            item.NatalDay = MtbBirth.Text;
            item.Smoker = (int)selectedSmoke.Value;
            item.Allergies = TxbAllergies.Text; 
            item.Id = id.Value;

            _service.Edit(item);
            MessageBox.Show("The patients was edited bacanamente", "System");
        }

        public void LoadCbx()
        {
            ComboBoxItem defaultOption = new ComboBoxItem();
            {
                defaultOption.Text = "Select an option";
                defaultOption.Value = new int();
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
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                AddPatient();
            }
            else
            {
                EditPatient();
            }
            this.Close();
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
    }
}
