using System;
using Xunit;
using ModelEnterprise.Service;
using System.Linq;

namespace ModelEnterprise.XUnitTest
{
    public class UnitTest1
    {
        private readonly GeneralService _generalService;
        private readonly string _connectionString;
        string UserName = "hidir.isitmez";
        public UnitTest1()
        {
            _connectionString = "Server=37.148.212.86;Database=BildirimTakip;User Id=sa;Password=ModelMbi2019@;";
            _generalService = new GeneralService(_connectionString);
        }


        //[Fact]
        //public void Test1() // check
        //{
        //    var data = _generalService.Test().ToList();
        //    Assert.NotNull(data);
        //}

        [Fact]
        public void GetAllIssue() // check
        {

            var data = _generalService.GetAllIssue(UserName).ToList();
            Assert.NotNull(data);
        }
    }
}
