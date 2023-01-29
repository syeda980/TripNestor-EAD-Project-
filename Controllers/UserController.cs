﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models;

namespace TripNestor.Controllers
{
    public class UserController : Controller
    {
        TripNestorContext tripNestorContext = new TripNestorContext();
        public ViewResult Signup()
        {
            return View();
        }
        public ViewResult Signin()
        {
            return View("signin");
        }
        [HttpPost]
        public ViewResult AddUserToDB(string userName,string userEmail,string userPassword)
        {
            User newUser = new User();
            newUser.Name = userName;
            newUser.Email = userEmail;
            newUser.Password = userPassword;
            tripNestorContext.Users.Add(newUser);
            int enteries=tripNestorContext.SaveChanges();
            if (enteries > 0)
            {
                ViewBag.Message = "Account has been successfully Registered!!!";
                ViewBag.flag = true;
            }
            else
            {
                ViewBag.Message = "Sorry Account can't be registered at the moment... Please try Again";
                ViewBag.flag = false;
            }
            return View("signin");
        }

        [HttpPost]
        public ViewResult Login(User user)
        {
            var userExist = tripNestorContext.Users.FirstOrDefault(u => u.Email== user.Email && u.Password == user.Password);

            if(userExist!=null)
            {
                //cookies management 
                HttpContext.Response.Cookies.Append("userEmail",user.Email);
                HttpContext.Response.Cookies.Append("userPassword", user.Password);
                return View("userHome");
            }
            else
            {
                ViewBag.invalidmsg = "Invalid Username or password";
                ViewBag.flag = false;
                ViewBag.invalid = true;
                //ModelState.Clear();//clear the fields
                return View("signin");

            }

        }

    }
}
