using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientSystem.Keep
{
    public partial class FrmListDoctor : Form
    {
        public FrmListDoctor()
        {
            InitializeComponent();
        }

        private void FrmListDoctor_Load(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDate date = new FrmDate();
            date.Show();
        }
    }
}
