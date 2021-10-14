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
            //removes the errors that wont be needed on login page
            ModelState.Remove("FullName");
            ModelState.Remove("PhoneNumber");
            ModelState.Remove("PasswordConfirmation");

            //checks if input is valid
            if (!ModelState.IsValid)
                return View("Login");

            //checks if user credentials are correct, if they are proceeds to dashboard
            var matchedUser = Repository.Users.FirstOrDefault(x => x.Email == user.Email);
            if (matchedUser.Password == user.Password)
            {
                return RedirectToAction("Dashboard", matchedUser);

            }

            return View("Login");
        }

        public IActionResult Dashboard(User matchedUser)
        {
            //checks if user is logged in or not
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

            //checks if user already exists
            foreach (User user in Repository.Users)
            {
                if (user.Email == newUser.Email)
                {
                    ViewBag.EmailExists = "";
                    return View("Index");
                }

            }

            //checks if password and its confirmation matches, if not shows an error
            if (newUser.Password != newUser.PasswordConfirmation)
                ModelState.AddModelError(string.Empty, "The password and its confirmation should be the same");

            //checks if user input is valid
            if (!ModelState.IsValid)
                return View("Index");

            //add new user to repository
            Repository.AddUser(newUser);

            return RedirectToAction("Login");
        }
    }
}
