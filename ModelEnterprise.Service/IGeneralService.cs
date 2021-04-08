using System.Collections.Generic;

namespace ModelEnterprise.Service
{
    public interface IGeneralService
    {
        List<dynamic> Test();
        List<dynamic> GetAllIssue(string UserName);
    }
}
