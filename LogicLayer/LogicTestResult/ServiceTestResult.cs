using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DataLayer.ResultTestData;

namespace LogicLayer.LogicTestResult
{
    public class ServiceTestResult
    {
        SqlConnection _cn;
        ResultTestRepository _repo;

        ServiceTestResult(SqlConnection cn)
        {
            _cn = cn;
            _repo = new ResultTestRepository(_cn);
        }

        public bool ChangesApoitment(int id)
        {                        
            return _repo.EditApt(id);                                   
        }

        private bool AddResult(int id, string Result)
        {
            return _repo.edit(id, Result);
        }
    }
}
