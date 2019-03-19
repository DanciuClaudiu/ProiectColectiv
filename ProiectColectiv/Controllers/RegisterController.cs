using Microsoft.AspNetCore.Mvc;
using ProiectColectiv.Models;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ProiectColectiv.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            var user = new User();
            return View("~/Views/Home/Register.cshtml", user);
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                MailAddress m = new MailAddress(user.Email);
                Regex regex = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");
                Regex regex2 = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
                if (!regex.IsMatch(user.Password) || !regex2.IsMatch(user.Name))
                {
                    throw new System.FormatException();
                }
                return RedirectToAction("Login", "Login");
            }
            catch(System.FormatException)
            {
                return RedirectToAction("RegisterError", "Register");
            }
        }
        [HttpGet]
        public ActionResult RegisterError()
        {
            var user = new User();
            return View("~/Views/Home/RegisterError.cshtml", user);
        }
        [HttpPost]
        public ActionResult RegisterError(User user)
        {
            try
            {
                MailAddress m = new MailAddress(user.Email);
                Regex regex = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");
                Regex regex2 = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
                if (!regex.IsMatch(user.Password) || !regex2.IsMatch(user.Name))
                {
                    throw new System.FormatException();
                }
                return RedirectToAction("Login", "Login");
            }
            catch (System.FormatException)
            {
                return RedirectToAction("RegisterError", "Register");
            }
        }
    }
}