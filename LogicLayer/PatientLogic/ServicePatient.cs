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
            repo = new PatientsRepository(_connection);
        }
        public bool Add(PatientsModel item)
        {
            try
            {
                string identification = (repo.ValidationExist(item.Identification).Identification != item.Identification ? "" : (repo.ValidationExist(item.Identification)).Identification.Trim());


                if (identification != item.Identification)
                {
                    return repo.Add(item);                                      
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
            return repo.SavePhoto(Photo, id);
        }
        public bool Edit(PatientsModel item, string Identification)
        {
            try
            {
                if (item.Identification == Identification)
                {
                    return repo.Edit(item, GlobalRepositoty.Instance.id);
                }
                else if (repo.ValidationExist(item.Identification).Identification != item.Identification)
                {
                    return repo.Edit(item, GlobalRepositoty.Instance.id);
                }
                else if (repo.ValidationExist(item.Identification).Identification.Trim() != item.Identification)
                {
                    return repo.Edit(item, GlobalRepositoty.Instance.id);
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
            return repo.Delete(id);
        }
        public int GetLastId()
        {
            return repo.GetLastId();
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
