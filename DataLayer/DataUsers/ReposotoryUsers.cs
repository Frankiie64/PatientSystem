using System;
using System.Collections.Generic;
using System.Data;
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
        public bool Edit(Users Usuario,int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update Users set FName = @FName,LastName = @LastName, Email = @Email, NickName = @NickName, Pass = @Pass,TypeUsers = @TypeUsers where Id=@Id", _connection);
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@FName", Usuario.FName);
            sqlCommand.Parameters.AddWithValue("@LastName", Usuario.LastName);
            sqlCommand.Parameters.AddWithValue("@Email", Usuario.Email);
            sqlCommand.Parameters.AddWithValue("@NickName", Usuario.NickName);
            sqlCommand.Parameters.AddWithValue("@Pass", Usuario.Pass);
            sqlCommand.Parameters.AddWithValue("@TypeUsers", Usuario.TypeUsers);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return ExecuteDml(sqlCommand);
        }
        public bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand(" delete Users where id=@id", _connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return ExecuteDml(sqlCommand);
        }
        public Users GetId(int id)
        {

            try
            {
                
                _connection.Open();

                SqlCommand command = new SqlCommand("select FName,LastName,Email,NickName,Pass,TypeUsers from Users where Id = @Id", _connection);
                command.CommandType = CommandType.Text;
                
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Users ReturnUsers = new Users();

                while (reader.Read())
                {
                    ReturnUsers.FName = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    ReturnUsers.LastName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    ReturnUsers.Email = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    ReturnUsers.NickName = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    ReturnUsers.Pass = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    ReturnUsers.TypeUsers = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return ReturnUsers;
            }
            catch (Exception ex)
            {

                return null;
            }


        }
       


        public DataTable GetallUsers()
        {
            SqlCommand command = new SqlCommand("select Users.Id, Users.FName as 'First name', Users.LastName as 'Last Name', Users.Email,Users.NickName as 'Users', Rol.Nombre as 'Rol' from Users inner join Rol on Users.TypeUsers = Rol.id", _connection);
            command.CommandType = CommandType.Text;
            
            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }

        private DataTable LoadTable(SqlDataAdapter Query)
        {
            try
            {

                DataTable Data = new DataTable();

                _connection.Open();

                Query.Fill(Data);

                _connection.Close();

                return Data;

            }
            catch (Exception ex)
            {

                return null;
            }

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

    }
}
