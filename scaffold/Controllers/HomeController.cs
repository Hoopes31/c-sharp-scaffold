using System;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DbConnection;

namespace scaffold.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbConnector _dbConnector;
 
        public HomeController(DbConnector connect)
        {
            _dbConnector = connect;
        }
        
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }

    // Session:
    // HttpContext.Session.SetString("KeyName", "Value");
    // string sessionStr = HttpContext.Session.GetString("KeyName");

    // HttpContext.Session.SetInt32("KeyName", Int);
    // int? sessionInt = HttpContext.Session.GetInt32("KeyName");

    // JSON:
    // session.SetString(key, JsonConvert.SerializeObject(value);
    // string jsonValue = session.GetString(key)
    // JsonConvert.DeserializeObject<T>(value);
}
