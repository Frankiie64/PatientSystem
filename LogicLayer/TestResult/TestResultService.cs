using DataLayer.LabResultData;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LogicLayer.TestResult
{
    public class TestResultService
    {

        SqlConnection _cn;
        LabResultRepository repo;

        public TestResultService(SqlConnection cn)
        {
            _cn = cn;
            repo = new LabResultRepository(_cn);
        }
        public LabResult GetById(int id)
        {
            return repo.GetId(id);
        }
        public DataTable GetAll()
        {
            return repo.Getall();
        }
    }
}
