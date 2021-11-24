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

                _connection.Open();

                SqlCommand command = new SqlCommand("select FName,LastName,Email,NickName,Pass,TypeUsers from Users where Id = @Id", _connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Appointment date = new Appointment();

                while (reader.Read())
                {
                    date.Id = reader.GetInt32(0) ? "" : reader.GetInt32(0);
                    date.LastName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    date.Email = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    date.NickName = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    date.Pass = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    

                }
                _connection.Close();

                reader.Close();
                reader.Dispose();

                return date;
            }
            catch (Exception ex)
            {

                return null;
            }


        }
        public DataTable GetallKeeps()
        {
            SqlCommand command = new SqlCommand("select Appointment.Id Patients.FName as 'Nombre del paciente', Doctors.FName as 'Nombre del doctor', Date_Appointment as 'Fecha', Cause 'Motivo', StatusAppointment as 'Estatus'from Appointment inner join Patients on Patients.Id = Appointment.Id_Patients inner join Doctors on Doctors.id = Appointment.Id_Doctor", _connection);
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
