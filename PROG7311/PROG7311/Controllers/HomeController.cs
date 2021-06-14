using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROG7311.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PROG7311.Controllers
{
    public class HomeController : Controller
    {
        private readonly _19003646_prog7311Context db;

        public HomeController(_19003646_prog7311Context context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

       
       
    }
}