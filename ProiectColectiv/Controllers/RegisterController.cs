using Microsoft.AspNetCore.Mvc;
using ProiectColectiv.Models;

namespace ProiectColectiv.Controllers
{
    public class RegisterController : Controller
    {
        // GET
        public ActionResult Register(User user)
        {
            return View("~/Views/Home/Register.cshtml", user);
        }
    }
}