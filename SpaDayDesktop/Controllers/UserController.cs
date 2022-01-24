using Microsoft.AspNetCore.Mvc;
using SpaDayDesktop.Models;

namespace SpaDayDesktop.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(verify.Equals(newUser.Password)) {
                ViewBag.NewUser = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords must match.";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }

    }
}
