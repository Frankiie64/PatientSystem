using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer.ResultTestData;
using DataLayer.Models;

namespace LogicLayer.LogicTestResult
{
    public class ServiceTestResult
    {
        SqlConnection _cn;
        ResultTestRepository _repo;

        public ServiceTestResult(SqlConnection cn)
        {
            _cn = cn;
            _repo = new ResultTestRepository(_cn);
        }

        public DataTable GetResultByIdent(string identification)
        {
            return _repo.GetResultByIdent(identification);
        }
        public bool AddResult(LabResult result,int id )
        {
            return _repo.AddResult(id, result);
           
        }
        public DataTable GetList()
        {
            return _repo.GetAll();
        }
        public LabResult GetById(int id)
        {
            return _repo.GetId(id);
        }

       
    }
}
