using System;
using System.Data.SqlClient;
using DataLayer;
using DataLayer.Login;
using DataLayer.Models;

namespace LogicLayer.Login
{
    public class ServiceLogin
    {
        private SqlConnection _connection;
        RepositoryLogin data;

        public ServiceLogin(SqlConnection connection)
        {
            _connection = connection;
            data = new RepositoryLogin(_connection);
        }

        public int Login(Users User)
        {
            try
            {
                if (data.ValidationExist(User.NickName).NickName == null)
                {
                    return 1;
                }
                else
                {
                    string DataNickName = data.ValidationExist(User.NickName).NickName.Trim();
                    string DataPass = data.ValidationExist(User.NickName).Pass.Trim();

                    
                    if (DataNickName != User.NickName)
                    {
                        return 1;
                    }
                    else if (DataPass != User.Pass)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }


    }
}
