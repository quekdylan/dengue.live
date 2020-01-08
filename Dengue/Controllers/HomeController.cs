using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.AspNetCore.Mvc;
using Dengue.Models;

namespace Dengue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignUp(EmailRecord emailRecord)
        {
            var firebaseClient = new FirebaseClient("https://denguelive-47836.firebaseio.com");
            var result = await firebaseClient
              .Child(emailRecord.Location)
              .PostAsync(emailRecord);
            TempData["msg"] = "<script>alert('Sign up successful');</script>";
            return RedirectToAction("Index");
        }

        [Route("/prevention")]
        public ActionResult Prevention()
        {
            return View();
        }

        [Route("/about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("/risk")]
        public ActionResult Risk()
        {
            return View();
        }

        [Route("/dashboard")]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}