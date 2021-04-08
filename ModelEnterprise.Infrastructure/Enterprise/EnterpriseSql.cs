using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEnterprise.Infrastructure.Enterprise.Entity;
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
        public List<dynamic> GetAllIssue(string UserName)
        {
            Dapper.DynamicParameters parameters = new();
            parameters.Add("@UserName", UserName, System.Data.DbType.String);
            var data = _mssqlService.GetAll<dynamic>("EXEC MainIssueList @UserName", parameters, System.Data.CommandType.Text);
      
            return data.ToList();
        }
        //

        //
        //public MainResult GetAllIssue(string UserName)
        //{
        //    MainResult result = new MainResult();

        //    try
        //    {
        //        Dapper.DynamicParameters parameters = new Dapper.DynamicParameters();
        //        parameters.Add("@UserName", UserName, System.Data.DbType.String);
        //        var data = _mssqlService.GetAll<dynamic>("EXEC MainIssueList @UserName", parameters,System.Data.CommandType.Text);
        //        result.data = data;
        //        result.State = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        result.State = false;
        //        result.Message = ex.ToString();
        //    }
        //    return result;
        //}
    }
}
