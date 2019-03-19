using Microsoft.AspNetCore.Mvc;
using ProiectColectiv.Models;

namespace ProiectColectiv.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            var user = new User();
            return View("~/Views/Home/Login.cshtml",user);
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.Username.Equals("admin") && user.Password.Equals("admin"))
            {
                return RedirectToAction("AdminMap", "AdminMap", user);
            }
            else
            {
                return RedirectToAction("UserMap", "UserMap", user);
            }           
        }
    }
}