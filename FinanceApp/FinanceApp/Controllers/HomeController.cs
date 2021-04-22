using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FinanceApp.Models;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        financeworksContext ctx;
        public HomeController(financeworksContext context)
        {
            ctx = context;
        }

        public IActionResult Get()
        {
            List<User> list = new List<User>();
            var result = ctx.Users.ToList();

            return Ok(result);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
