using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FinanceApp.Models;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        financeworksContext ctx;
        public WeatherForecastController(financeworksContext context)
        {
            ctx = context;
        }

        public IActionResult Get()
        {
            List<User> list = new List<User>();
            var result = ctx.Users.ToList();

            return Ok(result);
        }
    }
}
