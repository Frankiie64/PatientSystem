using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;

namespace DataLayer.DataUsers
{
    public class ReposotoryUsers
    {
        private SqlConnection _connection;

        public ReposotoryUsers(SqlConnection connection)
        {
            _connection = connection;
        
        }

        public bool AddUser(Users Usuario)
        {

            SqlCommand sqlCommand = new SqlCommand("insert into Users(FName,LastName,Email,NickName,Pass,TypeUsers) values(@FName,@LastName,@Email,@NickName,@Pass,@TypeUsers)", _connection);

            sqlCommand.Parameters.AddWithValue("@FName", Usuario.FName);
            sqlCommand.Parameters.AddWithValue("@LastName", Usuario.LastName);
            sqlCommand.Parameters.AddWithValue("@Email", Usuario.Email);
            sqlCommand.Parameters.AddWithValue("@NickName", Usuario.NickName);
            sqlCommand.Parameters.AddWithValue("@Pass", Usuario.Pass);
            sqlCommand.Parameters.AddWithValue("@TypeUsers", Usuario.TypeUsers);
            
            return ExecuteDml(sqlCommand);
        }
        private bool ExecuteDml(SqlCommand command)
        {
            try
            {
                _connection.Close();
                _connection.Open();

                command.ExecuteNonQuery();

                _connection.Close();

                return true;

            }
            catch (Exception ex)
            {

                return false;


            }


        }
    }
}
