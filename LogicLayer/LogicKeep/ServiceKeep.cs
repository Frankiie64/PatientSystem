using DataLayer.DataKeep;
using DataLayer.DataUsers;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LogicLayer.LogicKeep
{
    public class ServiceKeep
    {

        SqlConnection _connection;
        RepositoryKeep _repo;
        public ServiceKeep(SqlConnection connection)
        {
            _connection = connection;
            _repo = new RepositoryKeep(_connection);
        }

        #region Keeps
        public bool AddApointment(Appointment appointment)
        {
            return _repo.AddDate(appointment);
        }
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
        public Appointment GetById(int id)
        {
            return _repo.GetId(id);
        }
        public DataTable GetAll()
        {
            return _repo.GetallKeeps();
        }
        #endregion
        #region Doctor
        public Doctors GetDoctorsById(int id)
        {
            return _repo.GetByIdDoc(id);
        }
       
        public DataTable GetUniqueDoctors(string identification)
        {
            return _repo.GetUniqueDoctors(identification);
        }
        #endregion

        #region Patiens
        public DataTable GetListPatients()
        {
            return _repo.GetAllPatients();
        }
        public DataTable GetUniquePatients(string identification)
        {
            return _repo.GetUniquePatients(identification);
        }
        public PatientsModel GetPatientsById(int id)
        {
            return _repo.GetByIdPatient(id);
        }

        #endregion
    }
}
