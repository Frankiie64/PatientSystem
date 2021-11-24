using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.ResultTestData
{
    public class ResultTestRepository
    {
        SqlConnection _cn;
        public ResultTestRepository(SqlConnection cn)
        {
            _cn = cn;
        }
        public DataTable GetAll()
        {
            SqlCommand cmd = new SqlCommand("select LabResult.Id Patients.FName as 'Name', Patients.LastName as 'Last Name', Patients.identification,LabTest.Title from LabResult inner join Patients ON id_Patients = Patients.id INNER JOIN LabTest ON id_LabTest = LabTest.id", _cn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(cmd);
            return LoadTable(query);
        }
        public LabResult GetId(int id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("select Patients.FName as 'Patient Name'  from LabResult inner join Patients ON id_Patients = Patients.id where id = @id", _cn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                LabResult returnResult = new LabResult();
                while (reader.Read())
                {
                    returnResult.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                }
                _cn.Close();
                reader.Close();
                reader.Dispose();

                return returnResult;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        private DataTable LoadTable(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();
                _cn.Open();
                query.Fill(data);
                _cn.Close();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool EditApt(int id)
        {
            SqlCommand cmd = new SqlCommand("update Appointment set StatusAppointment =+ 1 where Id = @id", _cn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", id);

            return ExecuteDml(cmd);
        }
        public bool edit(int id,string StatusResult)
        {
            SqlCommand cmd = new SqlCommand("update LabResult set StatusResult = @StatusResult where Id = @id;", _cn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@StatusResult", StatusResult);
            cmd.Parameters.AddWithValue("@id", id);

            return ExecuteDml(cmd);
        }
        private bool ExecuteDml(SqlCommand command)
        {
            try
            {
                _cn.Close();
                _cn.Open();

                command.ExecuteNonQuery();

                _cn.Close();

                return true;

            }
            catch (Exception ex)
            {

                return false;


            }

        }
    }
}
