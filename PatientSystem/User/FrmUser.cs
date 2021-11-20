using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientSystem.Login;


namespace PatientSystem.User
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        #region
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUsers Add = new FrmAddUsers(FrmLogin.Intance.connectionString);
            this.Close();
            Add.Show();
        }



        #endregion

    }
}
