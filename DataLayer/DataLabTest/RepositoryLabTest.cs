using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.DataLabTest
{
    public class RepositoryLabTest
    {
        SqlConnection _connection;

        public RepositoryLabTest(SqlConnection connection)
        {
            _connection = connection;

        }
        public bool AddUser(LabTest Test)
        {

            SqlCommand sqlCommand = new SqlCommand("insert into LabTest(Title) values(@Title)", _connection);

            sqlCommand.Parameters.AddWithValue("@Title", Test.Titles);           

            return ExecuteDml(sqlCommand);
        }
        public bool Edit(LabTest Test, int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update LabTest set Title = @Title where id=@id", _connection);
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@Title", Test.Titles);            
            sqlCommand.Parameters.AddWithValue("@id", id);

            return ExecuteDml(sqlCommand);
        }
        public bool DeleteLabTest(int id)
        {
            SqlCommand sqlCommand = new SqlCommand(" delete LabTest where id=@id", _connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return ExecuteDml(sqlCommand);
        }
      

        public DataTable GetallUsers()
        {
            SqlCommand command = new SqlCommand("select * from LabTest", _connection);
            command.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }
        public LabTest GetId(int id)
        {

            try
            {

                _connection.Open();

                SqlCommand command = new SqlCommand("select Title from LabTest where id = @Id", _connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                LabTest ReturnUsers = new LabTest();

                while (reader.Read())
                {
                    ReturnUsers.Titles = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    
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
        public LabTest ValidationExist(string Titulo)
        {
            try
            {
                _connection.Close();
                _connection.Open();

                SqlCommand command = new SqlCommand("Select Title From LabTest where Title= @Title", _connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@Title", Titulo);

                SqlDataReader reader = command.ExecuteReader();

                LabTest test = new LabTest();

                while (reader.Read())
                {                  
                    test.Titles = reader.IsDBNull(0) ? "" : reader.GetString(0);

                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return test;

            }
            catch (Exception ex)
            {
                return null;
            }
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

    }
}
