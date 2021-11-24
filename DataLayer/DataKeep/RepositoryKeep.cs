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
            SqlCommand sqlCommand = new SqlCommand(" delete Appointment where id=@id", _connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

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
                    date.Date_Appointment = reader.IsDBNull(3) ? "" : reader.GetString(3);
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
        public DataTable GetListPatients(string identification)
        {
            SqlCommand command = new SqlCommand("select * from Patients where Identification = @identification", _connection);
            command.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }
        public DataTable GetListDoctors(string identification)
        {
            SqlCommand command = new SqlCommand("select * from Doctors where Identification = @identification", _connection);
            command.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
        }    
        public DataTable GetallKeeps()
        {
            SqlCommand command = new SqlCommand("select Appointment.id, Patients.FName as 'Patient Name', Doctors.FName as 'Doctor Name', Appointment.Date_Appointment as 'Date Appointment', Appointment.Cause, StatusDate.Text as 'Status Date' from Appointment INNER JOIN Patients ON Id_Patients = Patients.Id INNER JOIN Doctors ON Id_Doctor = Doctors.Id INNER JOIN StatusDate ON StatusAppointment = StatusDate.id", _connection);
            command.CommandType = CommandType.Text;

            SqlDataAdapter query = new SqlDataAdapter(command);

            return LoadTable(query);
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
    }
}
