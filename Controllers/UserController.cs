using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        PlaceRepository prepo = new PlaceRepository();
        HotelRepository hrepo = new HotelRepository();
        HotelImageRepository hotelImg = new HotelImageRepository();
        PlaceImageRepository PlaceImage = new PlaceImageRepository();
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
            if (ModelState.IsValid)
            {
                User newUser = new User();
                newUser.Name = userName;
                newUser.Email = userEmail;
                newUser.Password = userPassword;
                tripNestorContext.Users.Add(newUser);
                int enteries = tripNestorContext.SaveChanges();
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
                return View("userHome","user");
            }
            else
            {
                ViewBag.invalidmsg = "Invalid Email or password";
                ViewBag.flag = false;
                ViewBag.invalid = true;
                return View("signin");

            }

        }
        public ViewResult userHome()
        {
            if (HttpContext.Request.Cookies.ContainsKey("userEmail")
                && HttpContext.Request.Cookies.ContainsKey("userPassword"))
            {
                return View("userHome");
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return View("signin");
            }
        }
        public ViewResult searchPlace()
        {
            return View("searchPlace");
        }
        public ViewResult SearchAplace(string Pname,string cities)
        {
            if (HttpContext.Request.Cookies.ContainsKey("userEmail"))
            {
                var email = Request.Cookies["UserEmail"];
                int cid = 0;
                string cName = "";
                if (cities == "1")
                {
                    cid = 1;
                    cName = "Lahore";

                }
                else if (cities == "2")
                {
                    cid = 2;
                    cName = "Karachi";
                }
                else if (cities == "3")
                {
                    cid = 3;
                    cName = "Islamabad";
                }
                else if (cities == "4")
                {
                    cid = 4;
                    cName = "Swat";
                }
                ViewBag.error = "Not such place Found";
                ViewBag.flag = true;
               int id= prepo.getPlaceId(Pname, cid);

                if (id!=-1)
                {
                    Place p = prepo.SearchInDB(cid, id);
                    List<PlaceImage> pImg = PlaceImage.getImages(id);
                    p.PlaceImages = pImg;
                    ViewBag.cityName = cName;
                    ViewBag.flag = true;

                    return View("showSearch", p);
                }
                else

                {
                    ViewBag.flag = false;

                    return View("showSearch");

                }
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return View("signin");
            }


        }
        public ViewResult searchHotel()
        {
            return View("searchHotel");
        }

        public ViewResult SearchAhotel(string Hname, string cities)
        {
            if (HttpContext.Request.Cookies.ContainsKey("userEmail"))
            {
                var email = Request.Cookies["UserEmail"];
                int cid = 0;
                string cName = "";
                if (cities == "1")
                {
                    cid = 1;
                    cName = "Lahore";

                }
                else if (cities == "2")
                {
                    cid = 2;
                    cName = "Karachi";
                }
                else if (cities == "3")
                {
                    cid = 3;
                    cName = "Islamabad";
                }
                else if (cities == "4")
                {
                    cid = 4;
                    cName = "Swat";
                }
                ViewBag.error = "Not such Hotel Found";
                ViewBag.flag = true;
                int id = hrepo.getHotelId(Hname, cid);

                if (id != -1)
                {
                    Hotel p = hrepo.SearchInDB(cid, id);
                    List<HotelImages> pImg = hotelImg.getImages(id);
                    p.HotelImages = pImg;
                    ViewBag.cityName = cName;
                    ViewBag.flag = true;

                    return View("showSearchHotel", p);
                }
                else

                {
                    ViewBag.flag = false;

                    return View("showSearch");

                }
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return View("signin");
            }


        }

        public ViewResult Logout()
        {
            HttpContext.Response.Cookies.Delete("userEmail");
            HttpContext.Response.Cookies.Delete("userPassword");
            return View("signin","user");
        }

    }
}
