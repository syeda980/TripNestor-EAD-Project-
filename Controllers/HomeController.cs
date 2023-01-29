using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models;

namespace TripNestor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult UserHome()
        {
            return View();
        }
        public ActionResult Welcome(string option)
        {
           
            if(option=="user")
            {
                return RedirectToAction("Signin", "User");
            }
            else if(option=="admin")
            {
                return RedirectToAction("Signin", "Admin");

            }
            else
            {
                return View();
            }
;        }
        

    }
}
