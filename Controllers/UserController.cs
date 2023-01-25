using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Signup()
        {
            return View();
        }
        public ViewResult Signin()
        {
            return View("signin");
        }
    }
}
