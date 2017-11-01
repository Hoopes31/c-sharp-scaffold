using System;
using System.Linq;
using Newtonsoft.Json;
using scaffold.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace scaffold.Controllers
{
    public class BankController : Controller
    {
        private readonly MyContext _context;
        public BankController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("bank")]
        public IActionResult Index()
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            System.Console.WriteLine(id);
            // User user = _context.Users.Include(u => u.account).SingleOrDefault(u => u.id == id);
            Account account = _context.Accounts;
            // ViewBag.name = user.first_name;
            // ViewBag.balance = user.account.balance;

            return View();
        }
    }
}