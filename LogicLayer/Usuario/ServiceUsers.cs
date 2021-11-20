using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;
using DataLayer.DataUsers;

namespace LogicLayer.Usuario
{
    public class ServiceUsers
    {
        SqlConnection _connection;
        ReposotoryUsers DataUsers;
        public ServiceUsers(SqlConnection connection)
        {
            _connection = connection;
            DataUsers = new ReposotoryUsers(_connection);
        }

        public bool AddUser(Users rol)
        {
            return DataUsers.AddUser(rol);
        }
        

    }
}
