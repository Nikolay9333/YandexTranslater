using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace YandexTranslater.Controllers
{
    public class YandexTranslaterController : Controller
    {
        private IConfiguration _configuration;

        public YandexTranslaterController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Index()
        {
            var token = _configuration.GetValue<string>("translateToken");

            return Json(new {token = token});
        }
    }
}