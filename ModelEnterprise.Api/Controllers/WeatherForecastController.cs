using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelEnterprise.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelEnterprise.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class WeatherForecastController : ControllerBase
    {
        private readonly IGeneralService _service;
        
        public WeatherForecastController(IGeneralService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(string UserName)
        {
            var data = _service.GetAllIssue(UserName).ToList();
            return Ok(new
            {
                data,
                state = true,
                message = "İşlem Başarılıdır"
            });
        }
    }
}
