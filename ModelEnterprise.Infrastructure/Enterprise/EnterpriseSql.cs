using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEnterprise.InfrastructureService.Dapper;

namespace ModelEnterprise.Infrastructure.Enterprise
{
    public class EnterpriseSql
    {
        private readonly MsSqlService _mssqlService;
        public EnterpriseSql(string _connectionString)
        {
            _mssqlService = new MsSqlService(_connectionString);
        }

        public List<dynamic> InsertTab()
        {
           var data=_mssqlService.GetAll<dynamic>("Select * from databases with(nolock)", null,System.Data.CommandType.Text);
            return data;
        }
    }
}
