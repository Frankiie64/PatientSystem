using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;
using DataLayer.DataUsers;
using System.Data;

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
            try
            {
                if (DataUsers.ValidationExist(rol.NickName).NickName != rol.NickName)
                {
                    return DataUsers.AddUser(rol);
                }
                else if (DataUsers.ValidationExist(rol.NickName).NickName.Trim() != rol.NickName)
                {
                    return DataUsers.AddUser(rol);
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {

                return false;
            }
        }
        public bool EditUser(Users rol)
        {
            try
            {
                if (DataUsers.ValidationExist(rol.NickName).NickName != rol.NickName)
                {
                    return DataUsers.Edit(rol,GlobalRepositoty.Instance.id);
                }
                else if (DataUsers.ValidationExist(rol.NickName).NickName.Trim() != rol.NickName)
                {
                    return DataUsers.Edit(rol,GlobalRepositoty.Instance.id);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            return DataUsers.Delete(id);
        }
        public Users GetById(int id)
        {
            return DataUsers.GetId(id);
        }
        public DataTable LoadTable()
        {
            return DataUsers.GetallUsers();
        }

    }
}
