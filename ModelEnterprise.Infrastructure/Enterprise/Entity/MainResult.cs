using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEnterprise.Infrastructure.Enterprise.Entity
{
    public class MainResult
    {
        public List<dynamic> data { get; set; }
        public bool State { get; set; }
        public string Message { get; set; }

    }
}
