using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindCafe.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: //
        public IActionResult Index()
        {
            return View();
        }
    }
}