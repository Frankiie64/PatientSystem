using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer;
using DataLayer.Models;

namespace LogicLayer.Medical
{
    public class ServiceMedical
    {
        SqlConnection _connection;
        DataLayer.DataMedical DataMedical;

        public ServiceMedical(SqlConnection connection)
        {
            _connection = connection;
            DataMedical = new DataMedical(_connection);
        }
        public bool AddUDoc(Doctors Doc)
        {
            try
            {
                if (DataMedical.ValidationExist(Doc.Identification).Identification != Doc.Identification)
                {
                    return DataMedical.AddDoc(Doc);
                }
                else if (DataMedical.ValidationExist(Doc.Identification).Identification.Trim() != Doc.Identification)
                {
                    return DataMedical.AddDoc(Doc);
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
        public bool EditDoc(Doctors Doc)
        {
            try
            {
                if (DataMedical.ValidationExist(Doc.Identification).Identification != Doc.Identification)
                {
                    return DataMedical.Edit(Doc,GlobalRepositoty.Instance.id);
                }
                else if (DataMedical.ValidationExist(Doc.Identification).Identification.Trim() != Doc.Identification)
                {
                    return DataMedical.Edit(Doc, GlobalRepositoty.Instance.id);
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
        public bool DeleteDoc(int id)
        {
            return DataMedical.Delete(id);
        }
        public Doctors GetById(int id)
        {
            return DataMedical.GetId(id);
        }
        public DataTable LoadTable()
        {
            return DataMedical.GetallUsers();
        }


    }
}
