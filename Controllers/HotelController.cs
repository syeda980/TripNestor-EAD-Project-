using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models;

namespace TripNestor.Controllers
{
    public class HotelController : Controller
    {
        AdminRepository adminRepository = new AdminRepository();
        HotelRepository HotelRepository = new HotelRepository();
        HotelImageRepository HotelImageRepository = new HotelImageRepository();
        private readonly IWebHostEnvironment Environment;

        public HotelController(IWebHostEnvironment
          environment)
        {

            Environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult addHotel()
        {
            return View("addHotel");
        }
        public ActionResult addHoteltoDB(List<IFormFile> postedFiles, string cities, string Hname, int noforooms)
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {
                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int id = adminRepository.getAdminId(email1);

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

                string wwwPath = this.Environment.WebRootPath;
                string subPath = "uploads\\Hotels\\" + cName;
                string path = Path.Combine(wwwPath, subPath);
                List<string> fileNames = new List<string>();
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                foreach (var file in postedFiles)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var pathWithFileName = Path.Combine(path, fileName);
                    fileNames.Add(fileName);
                    using (FileStream stream = new
                        FileStream(pathWithFileName,
                        FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                bool result = HotelRepository.AddToDB(id, cid, Hname, noforooms);
                int placeId = HotelRepository.getHotelId(Hname, cid);
                 if (result == true)
                 {
                     bool res = HotelImageRepository.AddToDB(placeId, fileNames);
                     if (res == true)
                     {

                        ViewBag.addedMsg = "Hotel has been Added successfully";
                        ViewBag.flag = true;
                        return View("addHotel");
                    }
                    else
                    {
                        ViewBag.addedMsg = "Hotel can't be Added successfully";
                        ViewBag.flag = true;
                        return View("addHotel");
                    }
                }
                 else
                 {
                    ViewBag.addedMsg = "Hotel can't be Added successfully";
                    ViewBag.flag = true;
                    return View("addHotel");
                }

             }
             else
             {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return RedirectToAction("Signin", "Admin");
            }

            }
        public IActionResult EditHotel()
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {

                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int id = adminRepository.getAdminId(email1);
                List<Hotel> hotels = HotelRepository.GetAllHotels(id);
                return View("EditHotel", hotels);
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return RedirectToAction("Signin", "Admin");
            }
        }

        public ViewResult Edit(int id)
        {
            Hotel p = HotelRepository.FindHotel(id);
            return View("Edit", p);

        }
        [HttpPost]
        public ActionResult UpdateHotel(int id, string cities, string Hname, int noofrooms)
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {
                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int a_id = adminRepository.getAdminId(email1);

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
                bool result = HotelRepository.updateHotel(id, cid, Hname, noofrooms, a_id);
                List<Hotel> placesFound = HotelRepository.GetAllHotels(a_id);
                return View("EditHotel", placesFound);
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return RedirectToAction("Signin", "Admin");
            }
        }
        public ActionResult Remove(int id)
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {
                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int a_id = adminRepository.getAdminId(email1);

                bool res = HotelRepository.DeleteHotel(id);

                List<Hotel> HotelsFound = HotelRepository.GetAllHotels(id);
                return View("EditHotel", HotelsFound);
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return RedirectToAction("Signin", "Admin");
            }
        }
        public ViewResult ViewAll(int id)
        {
            List<Hotel> placesFound = HotelRepository.GetAllHotelssByCityId(id);

            string cName = "";
            if (id == 1)
            {
                cName = "Lahore";

            }
            else if (id == 2)
            {
                cName = "Karachi";
            }
            else if (id == 3)
            {
                cName = "Islamabad";
            }
            else if (id == 4)
            {
                cName = "Swat";
            }

            List<int> ids = new List<int>();
            foreach (var p in placesFound)
            {
                ids.Add(p.HotelId);
            }
            List<HotelImages> result = HotelImageRepository.getImagesInRange(ids);
            List<List<string>> data = new List<List<string>>();

            int i = 0;
            foreach (var p2 in placesFound)
            {
                List<string> obj = new List<string>();
                if (result[i].HotelId == p2.HotelId)
                {
                    obj.Add(p2.HotelName);
                    obj.Add(p2.NoOfRooms.ToString());
                    obj.Add(result[i].ImagePath);
                }
                i++;
                data.Add(obj);


            }
            ViewBag.cityName = cName;
            return View("ViewAllHotels", data);

        }

    }


}

