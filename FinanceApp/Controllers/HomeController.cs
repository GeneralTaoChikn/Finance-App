using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FinanceApp.Models;
using FinanceApp.Services;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        financeworksContext ctx;
        IFundService fs;

        public HomeController(financeworksContext context, IFundService fundService)
        {

            ctx = context;
            fs = fundService;
        }

        public IActionResult Get()
        {
            //var result = fs.UpdateFund();
            List<User> list = new List<User>();
            var result = ctx.Users.ToList();
            return Ok(result);
        }

    }
}
