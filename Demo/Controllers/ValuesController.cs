using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        [Route("GetHtml")]
        public string GetHtml()
        {
            _logger.LogError($"测试数据:{DateTime.Now}");
            return "出来了+再来一次+测试";
        }


        [Route("GetError")]
        public string GetError()
        {
            try
            {
                string s = null;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            

            return "出来了+再来一次+测试";
        }
    }
}
