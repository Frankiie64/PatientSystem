using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.LabResultData
{
    public class LabResultRepository
    {
        SqlConnection _cn;

        public LabResultRepository(SqlConnection cn)
        {
            _cn = cn;
        }
        public DataTable Getall()
        {
            SqlCommand cmd = new SqlCommand("select Patients.FName, Patients.LastName, Patients.identification,LabTest.Title from LabResult inner join Patients ON id_Patients = Patients.id inner join LabTest ON id_LabTest = LabTest.id", _cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter query = new SqlDataAdapter(cmd);
            return LoadTable(query);
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
        private bool ExecuteDml(SqlCommand cmd)
        {
            try
            {
                _cn.Close();
                _cn.Open();
                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public LabResult GetId(int id)
        {
            try
            {
                _cn.Open();

                SqlCommand cmd = new SqlCommand("select * from LabResult where Id = @id", _cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                LabResult returnTest = new LabResult();
                while (reader.Read())
                {
                    returnTest.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                }
                _cn.Close();
                reader.Close();
                reader.Dispose();

                return returnTest;
            }
            catch (Exception ex)
            {

                return null;
            }


        }

    }
}
