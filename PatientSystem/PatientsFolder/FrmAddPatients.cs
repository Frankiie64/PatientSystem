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
        FrmPatients patients = new FrmPatients();
        public FrmAddPatients()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection();
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
            if(selectedSmoke.Text == "Yes")
            { item.Smoker = true; }           
            else
            { item.Smoker = false; }

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
            if (selectedSmoke.Text == "Yes")
            { item.Smoker = true; }
            else
            { item.Smoker = false; }
            item.Allergies = TxbAllergies.Text;
            item.Id = id.Value;
            _service.Edit(item);
            MessageBox.Show("The patients was edited bacanamente", "System");
        }
        public void DgvPatients(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = e.RowIndex;
                BtnDeselect.Visible = true;

                PatientsModel patients = new PatientsModel();

                patients = _service.GetById(id.Value);

                TxbName.Text = patients.Fname;
                TxbLastName.Text = patients.LastName;
                MtbPhone.Text = patients.PhoneNumber;
                TxbAddress.Text = patients.Address;
                MtbCard.Text = patients.Identification;
                MtbBirth.Text = patients.NatalDay;
                if (patients.Smoker == true)
                {
                    CbxSmoker.Text = "Yes";
                }
                else
                { CbxSmoker.Text = "Nope"; }
                TxbAllergies.Text = patients.Allergies;
            }
        }
        public void LoadCbx()
        {
            ComboBoxItem defaultOption = new ComboBoxItem()
            {
                Text = "Select an option",
                Value = null
            };
            ComboBoxItem yesismoke = new ComboBoxItem()
            {
                Text = "Yes",
                Value = 1
            };
            ComboBoxItem noidontsmoke = new ComboBoxItem()
            {
                Text = "Nope",
                Value = 2
            };

            CbxSmoker.Items.Add(defaultOption.Text);
            CbxSmoker.Items.Add(yesismoke.Text);
            CbxSmoker.Items.Add(noidontsmoke.Text);
            CbxSmoker.SelectedItem = defaultOption.Text;
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
        }
    }
}
