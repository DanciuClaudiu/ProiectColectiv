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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
