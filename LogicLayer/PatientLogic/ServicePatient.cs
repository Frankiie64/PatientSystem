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
        private PatientsRepository _repo;
        public ServicePatient(SqlConnection connection)
        {
            _connection = connection;
            _repo = new PatientsRepository(_connection);
        }
        public bool Add(PatientsModel item)
        {
            try
            {
                string identification = (_repo.ValidationExist(item.Identification).Identification != item.Identification ? "" : (_repo.ValidationExist(item.Identification)).Identification.Trim());

                if (identification != item.Identification)
                {
                    return _repo.Add(item);                                      
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SavePhoto(int id, string Photo)
        {
            return _repo.SavePhoto(Photo, id);
        }
        public bool Edit(PatientsModel item, string Identification)
        {
            try
            {
                if (item.Identification == Identification)
                {
                    return _repo.Edit(item, GlobalRepositoty.Instance.id);
                }
                else if (_repo.ValidationExist(item.Identification).Identification != item.Identification)
                {
                    return _repo.Edit(item, GlobalRepositoty.Instance.id);
                }
                else if (_repo.ValidationExist(item.Identification).Identification.Trim() != item.Identification)
                {
                    return _repo.Edit(item, GlobalRepositoty.Instance.id);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
        public int GetLastId()
        {
            return _repo.GetLastId();
        }
        public PatientsModel GetById(int id)
        {
            return _repo.GetById(id);
        }
        public DataTable GetAll()
        {
            return  _repo.GetAll();
        }
    }
}
