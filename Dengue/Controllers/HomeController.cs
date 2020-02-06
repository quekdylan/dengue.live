using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using Dengue.Models;
using Grpc.Auth;

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
              .Child("Emails")
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
        public async Task<ActionResult> Dashboard()
        {
            ////var auth = "nwzXF5q91brr8gvq426wr7qq6M5ocj26C36HOtaU"; // your app secret
            //var firebaseClient = new FirebaseClient(
            //  "https://denguelive-47836.firebaseio.com/");
            //  //,
            //  //new FirebaseOptions
            //  //{
            //  //    AuthTokenAsyncFactory = () => Task.FromResult(auth)
            //  //});

            //var result = await firebaseClient.Child("cases").OnceAsync<>();
            //foreach (var location in result)
            //{

            //}
            return View();
        }
    }
}