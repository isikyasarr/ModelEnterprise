using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEnterprise.Infrastructure.Enterprise;

namespace ModelEnterprise.Service
{
    public class GeneralService : IGeneralService
    {
        private readonly EnterpriseSql _enterpriseSql;
        public GeneralService(string _connectionString)
        {
            _enterpriseSql = new EnterpriseSql(_connectionString);
        }

        public List<dynamic> Test()
        {
           return _enterpriseSql.InsertTab().ToList();
        }

    }
}
