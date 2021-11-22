using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;
using DataLayer.DataUsers;
using System.Data;
using EmailLayer;

namespace LogicLayer.Usuario
{
    public class ServiceUsers
    {
        SqlConnection _connection;
        ReposotoryUsers DataUsers;
        EmailSender email;

        public ServiceUsers(SqlConnection connection)
        {
            _connection = connection;
            DataUsers = new ReposotoryUsers(_connection);
        }

        private bool EnviarCorreo(string destinario, string titulo, string cuerpo)
        {
            email = new EmailSender();

            if (email.EnviarEmail(destinario, titulo, cuerpo))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int AddUser(Users rol)
        {
            try
            {
                string Datanickname = (DataUsers.ValidationExist(rol.NickName).NickName != null ? DataUsers.ValidationExist(rol.NickName).NickName.Trim() : "");
                if (Datanickname.ToLower() != rol.NickName.ToLower())
                {
                    if (DataUsers.AddUser(rol))
                    {
                        if (EnviarCorreo(rol.Email, "Se creado su usuario.", $"Recienteme se ha creado un usuario de tipo {(rol.TypeUsers == 0 ? "Administracion" : "Doctor" )} "))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                    else
                    {
                        return 2;
                    }

                }                
                else
                {
                    return 2;
                }
            }
            catch (Exception ex)
            {

                return 4;
            }        
        }
        public bool EditUser(Users rol,string nickname)
        {
            try
            {
                if(nickname == rol.NickName)
                {
                    return true;
                }
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
