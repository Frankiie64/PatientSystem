using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.DataKeep
{
    public class RepositoryKeep
    {

        private SqlConnection _connection;
        public RepositoryKeep(SqlConnection connection)
        {
            _connection = connection;
        }
        #region Keeps
        public bool AddDate(Appointment date)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Appointment(Id_Patients,Id_Doctor,Date_Appointment,Cause,StatusAppointment) values(@Id_Patients,@Id_Doctor,@Date_Appointment,@Cause,@StatusAppointment)", _connection);

            sqlCommand.Parameters.AddWithValue("@Id_Patients", date.Id_Patients);
            sqlCommand.Parameters.AddWithValue("@Id_Doctor", date.Id_Doctor);
            sqlCommand.Parameters.AddWithValue("@Date_Appointment", date.Date_Appointment);
            sqlCommand.Parameters.AddWithValue("@Cause", date.Cause);
            sqlCommand.Parameters.AddWithValue("@StatusAppointment", date.StatusAppointment);

            return ExecuteDml(sqlCommand);
        }
        public bool Edit(Appointment date, int id)
        {
            SqlCommand sqlCommand = new SqlCommand("update Appointment set Id_Patients = @Id_Patients,Id_Doctor = @Id_Doctor,Date_Appointment = @Date_Appointment,Cause = @Cause,StatusAppointment = @StatusAppointment where Id=@Id", _connection);
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@Id_Patients", date.Id_Patients);
            sqlCommand.Parameters.AddWithValue("@Id_Doctor", date.Id_Doctor);
            sqlCommand.Parameters.AddWithValue("@Date_Appointment", date.Date_Appointment);
            sqlCommand.Parameters.AddWithValue("@Cause", date.Cause);
            sqlCommand.Parameters.AddWithValue("@StatusAppointment", date.StatusAppointment);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return ExecuteDml(sqlCommand);
        }
        public bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand(" delete Appointment where Id=@id", _connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return ExecuteDml(sqlCommand);
        }
        public bool DeleteResult(int Id_Appointment)
        {
            SqlCommand sqlCommand = new SqlCommand(" delete LabResult where Id_Appointment=@Id_Appointment", _connection);

            sqlCommand.Parameters.AddWithValue("@Id_Appointment", Id_Appointment);

            return ExecuteDml(sqlCommand);
        }
        public Appointment GetId(int id)
        {
            try
            {
                _connection.Close();
                _connection.Open();

                SqlCommand command = new SqlCommand("select * from Appointment where Id = @id", _connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                Appointment date = new Appointment();

                while (reader.Read())
                {
                    date.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    date.Id_Patients = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    date.Id_Doctor = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    date.Date_Appointment = reader.IsDBNull(3) ? default : reader.GetDateTime(3);
                    date.Cause = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    date.StatusAppointment = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return date;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable GetallKeeps()
        {
            SqlCommand command = new SqlCommand("select Appointment.id, Patients.FName as 'Patient Name', Doctors.FName as 'Doctor Name', Appointment.Date_Appointment as 'Date Appointment', Appointment.Cause, StatusDate.Text as 'Status Date' from Appointment INNER JOIN Patients ON Id_Patients = Patients.Id INNER JOIN Doctors ON Id_Doctor = Doctors.Id INNER JOIN StatusDate ON StatusAppointment = StatusDate.id", _connection);
            command.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }
        #endregion
        #region Patiens
        public PatientsModel GetByIdPatient(int id)
        {
            try
            {
                _connection.Close();
                _connection.Open();

                SqlCommand cmd = new SqlCommand("select Id, FName from Patients where Id = @id", _connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                PatientsModel patient = new PatientsModel();

                while (reader.Read())
                {
                    patient.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    patient.Fname = reader.IsDBNull(1) ? "" : reader.GetString(1);
                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return patient;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetUniquePatients(string identification)
        {
            SqlCommand command = new SqlCommand("select * from Patients where Identification = @identification", _connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@identification", identification);

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }
        public DataTable GetAllPatients()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Patients.Id,FName as 'Name', LastName as 'Last Name', PhoneNumber as 'Phone Number', AddressPatient as Adress, Identification, NatalDay as Birthday, Smoker.text as '¿Smoker?', Allergies, photo from Patients inner join Smoker on Patients.Smoker = Smoker.id", _connection);
            return LoadTable(dataAdapter);
        }
        #endregion
        #region Doctors
        public DataTable GetUniqueDoctors(string identification)
        {
            SqlCommand command = new SqlCommand("select * from Doctors where Identification = @identification", _connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@identification", identification);

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }
        public Doctors GetByIdDoc(int id)
        {
            try
            {
                _connection.Close();
                _connection.Open();

                SqlCommand cmd = new SqlCommand("select Id, FName from Doctors where id = @id", _connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                Doctors doctors = new Doctors();

                while (reader.Read())
                {
                    doctors.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    doctors.FName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return doctors;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetallDoctors()
        {
            SqlCommand command = new SqlCommand("select Id,FName as 'Name', LastName as 'Last name', Email, PhoneNumber, Identification,Photos from Doctors", _connection);
            command.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }

        #endregion  




        #region Result
        public LabResult GetResultById(int Id_Appointment)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from LabResult where Id_Appointment = @Id_Appointment", _connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id_Appointment", Id_Appointment);

                SqlDataReader reader = cmd.ExecuteReader();
                LabResult result = new LabResult();

                while (reader.Read())
                {
                    result.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    result.Id_Patients = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    result.Id_Appointment = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    result.Id_LabTest = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    result.Id_Doctor = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    result.TestResult = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    result.StatusResult = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);

                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return result;

            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool AddResult(LabResult result)
        {
            try
            {               
                SqlCommand cmd = new SqlCommand("insert into LabResult(Id_Patients,Id_Doctor,Id_Appointment,Id_LabTest,TestResult,StatusResult) values(@id_patients,@id_doctor,@id_appointment,@lab_test,'No se han publicado resultado',2)", _connection);
                cmd.Parameters.AddWithValue("@id_patients", result.Id_Patients);
                cmd.Parameters.AddWithValue("@id_doctor", result.Id_Doctor);
                cmd.Parameters.AddWithValue("@id_appointment", result.Id_Appointment);
                cmd.Parameters.AddWithValue("@lab_test", result.Id_LabTest);

                return ExecuteDml(cmd);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateToCheck(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Appointment set StatusAppointment = 2 where Id = @id", _connection);
                cmd.Parameters.AddWithValue("@id", id);
                
                return ExecuteDml(cmd);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetListResult(int Id_Appointment)
        {
            SqlCommand command = new SqlCommand("select LabTest.Title as 'Nombre de la prueba', StatusDate.Text as 'Estatus' from LabResult inner join StatusDate on LabResult.StatusResult = StatusDate.id inner join LabTest on LabResult.Id_LabTest = LabTest.id where Id_Appointment = @Id_Appointment;", _connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@Id_Appointment", Id_Appointment);

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }
        public DataTable GetFinaltResult(int Id_Appointment)
        {
            SqlCommand command = new SqlCommand("select LabTest.Title as 'Nombre de la prueba', LabResult.TestResult as 'Resultado' from LabResult inner join LabTest on LabResult.Id_LabTest = LabTest.id where Id_Appointment = Id_Appointment", _connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@Id_Appointment", Id_Appointment);

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }

        #endregion



        #region Consult Genaral
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

        private DataTable LoadTable(SqlDataAdapter Query)
        {
            try
            {
                DataTable Data = new DataTable();

                _connection.Close();
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
        #endregion
    }

}