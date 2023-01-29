using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
        public ActionResult Login(Admin admin)
        {
            var userExist = tripNestorContext.Admins.FirstOrDefault(u => u.Email == admin.Email && u.Password == admin.Password);

            if (userExist != null)
            {
                //cookies management 
                HttpContext.Response.Cookies.Append("adminEmail", admin.Email);
                HttpContext.Response.Cookies.Append("adminPassword", admin.Password);
                return RedirectToAction("adminHome","Admin");
            }
            else
            {
                ViewBag.invalidmsg = "Invalid Email or password";
                ViewBag.invalid = true;
                return View("Signin");
            }
        }
        public ViewResult adminHome()
        {
            if(HttpContext.Request.Cookies.ContainsKey("adminEmail")
                && HttpContext.Request.Cookies.ContainsKey("adminPassword"))
            {
                return View("adminHome");
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return View("Signin");
            }
        }
        public ViewResult Logout()
        {
            HttpContext.Response.Cookies.Delete("adminEmail");
            HttpContext.Response.Cookies.Delete("adminPassword");
            return View("Signin");


        }
    }
}
