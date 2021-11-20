using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;
using DataLayer;

namespace DataLayer.Login
{
    public class RepositoryLogin
    {
                
            private SqlConnection _connection;

            public RepositoryLogin(SqlConnection connection)
            {
                _connection = connection;
            }


            public Users ValidationExist(string NickName)
            {
                try
                {
                    _connection.Open();

                    SqlCommand command = new SqlCommand("Select Id,NickName, Pass,TypeUsers From Users where NickName= @NickName", _connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@NickName", NickName);

                    SqlDataReader reader = command.ExecuteReader();

                    Users data = new Users();

                    while (reader.Read())
                    {
                        data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        data.NickName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        data.Pass = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        data.TypeUsers = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    }

                    reader.Close();
                    reader.Dispose();

                    _connection.Close();

                    return data;

                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            public bool ExecuteDml(SqlCommand sqlCommand)
            {
                try
                {

                    _connection.Open();

                    sqlCommand.ExecuteNonQuery();

                    _connection.Close();

                    return true;
                }
                catch
                {

                    return false;
                }


            }

        }
    }
