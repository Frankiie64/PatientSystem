using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer.Models;

namespace DataLayer.PatientData
{
    public class PatientsRepository
    {
        private SqlConnection _cn;
        public PatientsRepository(SqlConnection cn)
        {
            _cn = cn;
        }
        public bool Add(PatientsModel item)
        {
            SqlCommand cmd = new SqlCommand("insert into Patients(FName,LastName,PhoneNumber,AddressPatient,Identification,NatalDay,Smoker,Allergies) " +
                "values(@fname,@lastname,@phonenumber,@addresspatient,@identification,@natalday,@smoker,@allergies)", _cn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@fname", item.Fname);
            cmd.Parameters.AddWithValue("@lastname", item.LastName);
            cmd.Parameters.AddWithValue("@phonenumber", item.PhoneNumber);
            cmd.Parameters.AddWithValue("@addresspatient", item.Address);
            cmd.Parameters.AddWithValue("@identification", item.Identification);
            cmd.Parameters.AddWithValue("@natalday", item.NatalDay);
            cmd.Parameters.AddWithValue("@smoker", item.Smoker);
            cmd.Parameters.AddWithValue("@allergies", item.Allergies);

            return ExecuteDml(cmd);
        }
        public bool Edit(PatientsModel item)
        {
            SqlCommand cmd = new SqlCommand("update Patients set FName=@fname,LastName=@lastname,PhoneNumber=@phonenumber,AddressPatient=@addresspatient,Identification=@identification,NatalDay=@natalday,Smoker=@smoker,Allergies=@allergies where Id = @id", _cn);
            cmd.Parameters.AddWithValue("@fname", item.Fname);
            cmd.Parameters.AddWithValue("@lastname", item.LastName);
            cmd.Parameters.AddWithValue("@phonenumber", item.PhoneNumber);
            cmd.Parameters.AddWithValue("@addresspatient", item.Address);
            cmd.Parameters.AddWithValue("@identification", item.Identification);
            cmd.Parameters.AddWithValue("@natalday", item.NatalDay);
            cmd.Parameters.AddWithValue("@smoker", item.Smoker);
            cmd.Parameters.AddWithValue("@allergies", item.Allergies);           
            cmd.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(cmd);
        }
        public bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete Patients where Id = @id", _cn);
            cmd.Parameters.AddWithValue("@id", id);

            return ExecuteDml(cmd);
        }
        public DataTable GetAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Id,FName as 'Name', LastName as 'Last Name', PhoneNumber as 'Phone Number', AddressPatient as Adress, Identification, NatalDay as Birthday, Smoker as '¿Smoker?', Allergies, photo from Patients", _cn);
            return LoadData(dataAdapter);
        }
        public PatientsModel GetById(int id)
        {
            try
            {
                _cn.Close();
                _cn.Open();
                SqlCommand cmd = new SqlCommand("select Id, Fname, LastName, PhoneNumber, AddressPatient, Identification, NatalDay, Smoker, Allergies, photo from Patients where Id = @id", _cn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                PatientsModel returnData = new PatientsModel();

                while (reader.Read())
                {
                    returnData.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    returnData.Fname = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    returnData.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    returnData.PhoneNumber = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    returnData.Address = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    returnData.Identification = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    returnData.NatalDay = reader.IsDBNull(6) ? default : reader.GetDateTime(6);
                    returnData.Smoker = reader.IsDBNull(7) ? 2 :  reader.GetInt32(7);
                    returnData.Allergies = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    returnData.Photo = reader.IsDBNull(9) ? "" : reader.GetString(9);
                }
                reader.Close();
                reader.Dispose();

                _cn.Close();

                return returnData;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private DataTable LoadData(SqlDataAdapter dataAdapter)
        {
            try
            {
                _cn.Close();
                DataTable data = new DataTable();
                _cn.Open();
                dataAdapter.Fill(data);
                _cn.Close();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _cn.Close();
                _cn.Open();
                
                query.ExecuteNonQuery();

                _cn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
