using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;

namespace DataLayer
{
    public class DataMedical
    {
        SqlConnection _connection;

        public DataMedical(SqlConnection connection)
        {
            _connection = connection;
        }
        public bool AddDoc(Doctors Doct)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Doctors(FName,LastName,Email,PhoneNumber,Identification) values (@FName,@LastName,@Email,@PhoneNumber,@Identification)", _connection);
            sqlCommand.Parameters.AddWithValue("@FName", Doct.FName);
            sqlCommand.Parameters.AddWithValue("@LastName", Doct.LastName);
            sqlCommand.Parameters.AddWithValue("@Email", Doct.Email);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", Doct.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@Identification", Doct.Identification);
            
            return ExecuteDml(sqlCommand);
        }
        public bool SavePhoto(string photo, int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update Doctors set Photos = @Photos where Id = @Id", _connection);
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@Photos", photo);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return ExecuteDml(sqlCommand);
        }
        public bool Edit(Doctors Doct, int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update Doctors set FName = @FName,LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Identification = @Identification where Id=@Id", _connection);
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@FName", Doct.FName);
            sqlCommand.Parameters.AddWithValue("@LastName", Doct.LastName);
            sqlCommand.Parameters.AddWithValue("@Email", Doct.Email);
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", Doct.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@Identification", Doct.Identification);          
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return ExecuteDml(sqlCommand);
        }
        public bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Doctors where id=@id", _connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return ExecuteDml(sqlCommand);
        }
        public Doctors GetId(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select FName,LastName,Email,PhoneNumber,Identification from Doctors where Id = @Id", _connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Doctors ReturnUsers = new Doctors();

                while (reader.Read())
                {
                    ReturnUsers.FName = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    ReturnUsers.LastName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    ReturnUsers.Email = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    ReturnUsers.PhoneNumber = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    ReturnUsers.Identification = reader.IsDBNull(4) ? "" : reader.GetString(4);                    

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
        public int GetLastId()
        {
            try
            {
                _connection.Open();

                int LastId = 0;
                SqlCommand command = new SqlCommand("select MAX(Id) as id from Doctors", _connection);
               

                SqlDataReader reader = command.ExecuteReader();

                Doctors ReturnUsers = new Doctors();

                while (reader.Read())
                {
                   LastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                   
                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return LastId;
            }
            catch (Exception ex)
            {

                return 0;
            }


        }
        public DataTable GetallUsers()
        {
            SqlCommand command = new SqlCommand("select * from Doctors", _connection);
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
        public Doctors ValidationExist(string Identification)
        {
            try
            {
                _connection.Close();
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Identification From Doctors where Identification= @Identification", _connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@Identification", Identification);

                SqlDataReader reader = command.ExecuteReader();

                Doctors data = new Doctors();

                while (reader.Read())
                {
                    data.Identification = reader.IsDBNull(0) ? "" : reader.GetString(0);
                
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
