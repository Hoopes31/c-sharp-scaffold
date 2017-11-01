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
    public class NEWController : Controller
    {
        private readonly MyContext _context;
        public NEWController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("NEW_ROUTE")]
        public IActionResult Index()
        {
            int id = (int)HttpContext.Session.GetInt32("id");
           return View();
        }
    }
}