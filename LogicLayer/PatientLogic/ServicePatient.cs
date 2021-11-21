using DataLayer.Models;
using DataLayer.PatientData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LogicLayer.PatientLogic
{
    public class ServicePatient
    {
        private SqlConnection _connection;
        private PatientsRepository repo;
        public ServicePatient(SqlConnection connection)
        {
            _connection = connection;
        }
        public bool Add(PatientsModel item)
        {
            return repo.Add(item);
        }
        public bool Edit(PatientsModel item)
        {
            return repo.Edit(item);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
        public PatientsModel GetById(int id)
        {
            return repo.GetById(id);
        }
        public DataTable GetAll()
        {
            return  repo.GetAll();
        }

    }
}
