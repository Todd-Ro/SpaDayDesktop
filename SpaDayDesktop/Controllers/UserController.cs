using Microsoft.AspNetCore.Mvc;
using SpaDayDesktop.Models;
using SpaDayDesktop.ViewModels;

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
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("User/Add")]
        public IActionResult Add(User newUser, string VerifyPassword, AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if (VerifyPassword.Equals(newUser.Password))
                {

                    {
                        //ViewBag.NewUser = newUser;
                        /*TODO: Change return statement to 'return View("Index, newUser")' 
                         * and refactor Index view*/
                        return View("Index", newUser);
                    }

                }
                else
                {
                    ViewBag.error = "Passwords must match.";
                }
            }
            
                //This block executes if return statement above is not reached
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View(addUserViewModel);
            
            
        }

    }
}
