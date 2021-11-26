using DataLayer.DataKeep;
using DataLayer.DataUsers;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer.DataLabTest;

namespace LogicLayer.LogicKeep
{
    public class ServiceKeep
    {

        SqlConnection _connection;
        RepositoryKeep _repo;
        RepositoryLabTest labTest;

        public ServiceKeep(SqlConnection connection)
        {
            _connection = connection;
            _repo = new RepositoryKeep(_connection);
            labTest = new RepositoryLabTest(_connection);
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
        public DataTable GetListDoctors()
        {
            return _repo.GetallDoctors();
        }
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

        #region LabTest

        public DataTable GetListTest()
        {
            return labTest.GetallUsers();
        }
        #endregion

        #region LabResult
        public bool AddResult(LabResult result)
        {            
            if (_repo.AddResult(result))
            {
                _repo.UpdateToCheck(GlobalRepositoty.Instance.appointment.Id);
                return true;
            }
            else
            {
                return false;
            }
        }
        

        #endregion
    }
}
