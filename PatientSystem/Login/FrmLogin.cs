using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using PatientSystem.Login;
using System.Data.SqlClient;
using System.Configuration;
using LogicLayer.Login;
using DataLayer.Models;

namespace PatientSystem.Login
{
    public sealed partial class FrmLogin : Form
    {

        public static FrmLogin Intance { get; } = new FrmLogin();
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        SqlConnection connection;

        ServiceLogin service;
        private FrmLogin()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            service = new ServiceLogin(connection);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLoginInit_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {

            if (string.IsNullOrWhiteSpace(TxbLoginNick.Text) || string.IsNullOrWhiteSpace(TxbLoginPassword.Text))
            {
                MessageBox.Show("Por favor introduzca sus datos en los apartados correspondientes.", "Campos vacios");
            }
            else
            {
                Users Usuario = new Users();
                {
                    Usuario.NickName = TxbLoginNick.Text;
                    Usuario.Pass = TxbLoginPassword.Text;
                }

                if (service.Login(Usuario) == 0)
                {
                    MessageBox.Show("Ha ocurrrido un error inesperado, intentelo mas tarde", "Error desconocido");

                }
                else if (service.Login(Usuario) == 1)
                {

                    MessageBox.Show("El usuario con el que desea inicar seccion no existe", "Usuario no existe");

                }
                else if (service.Login(Usuario) == 2)
                {

                    MessageBox.Show("La contraseña no pertenece al usuario con el que desea iniciar seccion", "Contraseña Incorrecta");

                }
                else if (service.Login(Usuario) == 3)
                {

                    MessageBox.Show($"Bienvenido {TxbLoginNick.Text}", "Bienvenido");

                }
            }

        }
    } 
}
