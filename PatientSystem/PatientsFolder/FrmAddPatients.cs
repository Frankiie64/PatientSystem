using LogicLayer.PatientLogic;
using DataLayer.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PatientSystem;
using LogicLayer;

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

                _service.Add(item);
                MessageBox.Show("The patients was saved bacanamente", "System");
            }
            catch(Exception ex)
            {
                MessageBox.Show("The patients was not saved bacanamente", "System");

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
            if (item.Smoker == 0)
            {
                CbxSmoker.SelectedItem = smoker;

            }
            else
            {
                CbxSmoker.SelectedItem = nosmoker;
            }
            TxbAllergies.Text = item.Allergies;


            return  GlobalRepositoty.Instance.Patient;           
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

            if(_service.Edit(item,GlobalRepositoty.Instance.Patient.Identification))
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

            if (GlobalRepositoty.Instance.id > 0)
            {
                paciente(yesismoke, noidontsmoke);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
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
