using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult UserListing()
        {
            return View(Repository.Users);
        }

        public IActionResult SignOut()
        {
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(User user)
        {

            ModelState.Remove("FullName");
            ModelState.Remove("PhoneNumber");
            ModelState.Remove("PasswordConfirmation");

            if (!ModelState.IsValid)
                return View("Login");

            var matchedUser = Repository.Users.FirstOrDefault(x => x.Email == user.Email);
            if (matchedUser.Password == user.Password)
            {
                return RedirectToAction("Dashboard", matchedUser);

            }

            return View("Login");
        }

        public IActionResult Dashboard(User matchedUser)
        {
            if (matchedUser == null)
            {
                return RedirectToAction("Login");
            }
            return View("Dashboard", matchedUser);


        }

        [HttpPost]
        public IActionResult SignUp(User newUser)
        {
            //validate the user input
            foreach (User user in Repository.Users)
            {
                if (user.Email == newUser.Email)
                {
                    ViewBag.EmailExists = "";
                    return View("Index");
                }

            }

            if (newUser.Password != newUser.PasswordConfirmation)
                ModelState.AddModelError(string.Empty, "The password and its confirmation should be the same");

            if (!ModelState.IsValid)
                return View("Index");

            //add user to repo
            Repository.AddUser(newUser);

            //show login page
            return RedirectToAction("Login");
        }
    }
}
