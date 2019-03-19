using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProiectColectiv.Models;

using FireSharp.Config;
using FireSharp.EventStreaming;
using FireSharp.Exceptions;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Serialization;

namespace ProiectColectiv.Controllers
{
    public class HomeController : Controller
    {
        IFirebaseConfig firebaseConfig = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;
        


        public ActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public ActionResult UserMap(User user)
        {
            return View(user);
        }

        public IActionResult AdminMap()
        {
            return View();
        }

        

        [HttpGet]
        public ActionResult<User> Login()
        {
            var user=new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult<User> Login(User user )
        {

            

            if (user.Username.Equals("admin") && user.Password.Equals("admin"))
            {
                return RedirectToAction("UserMap", user);
            }
            return BadRequest("Bad Login.");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
