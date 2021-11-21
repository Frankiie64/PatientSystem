using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer.DataLabTest;
using DataLayer.Models;

namespace LogicLayer.FolderLabTest
{
    public class ServiceLabTest
    {
        SqlConnection _connection;
        RepositoryLabTest Data;

        public ServiceLabTest(SqlConnection connection)
        {
            _connection = connection;
            Data = new RepositoryLabTest(_connection);
        }
        public bool Add(LabTest test)
        {
            try
            {
                if (Data.ValidationExist(test.Titles).Titles != test.Titles)
                {
                    return Data.AddUser(test);
                }
                else if (Data.ValidationExist(test.Titles).Titles.Trim() != test.Titles)
                {
                    return Data.AddUser(test);
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
        public bool Edit(LabTest Test)
        {
            try
            {
                if (Data.ValidationExist(Test.Titles).Titles != Test.Titles)
                {
                    return Data.Edit(Test, GlobalRepositoty.Instance.id);
                }
                else if (Data.ValidationExist(Test.Titles).Titles.Trim() != Test.Titles)
                {
                    return Data.Edit(Test, GlobalRepositoty.Instance.id);
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
        public bool DeleteLabTest(int id)
        {
            return Data.DeleteLabTest(id);
        }
        public LabTest GetById(int id)
        {
            return Data.GetId(id);
        }
        public DataTable GetAll()
        {
            return Data.GetallUsers();
        }
    }
        
}

