using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models;

namespace TripNestor.Controllers
{
    public class AdminController : Controller
    {
        TripNestorContext tripNestorContext = new TripNestorContext();
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult SignIn()
        {
            return View();
        }
        public ViewResult Login(Admin admin)
        {
            var userExist = tripNestorContext.Admins.FirstOrDefault(u => u.Email == admin.Email && u.Password == admin.Password);

            if (userExist != null)
            {
                //cookies management 
                HttpContext.Response.Cookies.Append("userEmail", admin.Email);
                HttpContext.Response.Cookies.Append("userPassword", admin.Password);
                return View("adminHome");
            }
            else
            {
                ViewBag.invalidmsg = "Invalid Email or password";
                ViewBag.invalid = true;
                //ModelState.Clear();//clear the fields
                return View("Signin");

            }


        }

    }
}
