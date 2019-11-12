using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dengue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/prevention")]
        public ActionResult Prevention()
        {
            return View();
        }

        [Route("/how")]
        public ActionResult How()
        {
            return View();
        }

        [Route("/risk")]
        public ActionResult Risk()
        {
            return View();
        }
    }
}