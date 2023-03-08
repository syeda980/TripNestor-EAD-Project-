using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models;
using TripNestor.Models.Interfaces;

namespace TripNestor.Controllers
{
    public class PlaceController : Controller
    {
        public IAdmin adminRepo;
        public IPlace placeRepo;


       // PlaceRepository placeRepository = new PlaceRepository();
       // AdminRepository adminRepository = new AdminRepository();
        PlaceImageRepository placeImageRepository = new PlaceImageRepository();
        public PlaceController(IAdmin repository,IPlace placeRepo, IWebHostEnvironment
            environment)
        {
            this.adminRepo = repository;
            this.placeRepo = placeRepo;
            Environment = environment;

        }
        private readonly IWebHostEnvironment Environment;

      /*  public PlaceController(IWebHostEnvironment
            environment)
        {

            Environment = environment;
        }
*/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addPlace()
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {

                return View("addPlace");
            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return RedirectToAction("Signin", "Admin");
            }


        }
        public ActionResult addPlacetoDB(List<IFormFile> postedFiles, string cities, string pname, string description)
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {
                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int id = adminRepo.getAdminId(email1);

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
                string subPath = "uploads\\" + cName;
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

                bool result = placeRepo.AddToDB(id, cid, pname, description);

                int placeId = placeRepo.getPlaceId(pname, cid);
                if (result == true)
                {
                    bool res = placeImageRepository.AddToDB(placeId, fileNames);
                    if (res == true)
                    {
                        ViewBag.addedMsg = "Place has been Added successfully";
                        ViewBag.flag = true;
                        return View("addPlace");
                    }
                    else
                    {
                        ViewBag.addedMsg = "Place can't be Added successfully";
                        ViewBag.flag = true;
                        return View("addPlace");
                    }
                }
                else
                {
                    ViewBag.addedMsg = "Place can't be Added successfully";
                    ViewBag.flag = true;
                    return View("addPlace");
                }

            }
            else
            {
                ViewBag.invalidmsg = "Please Log in first to proceed further";
                ViewBag.invalid = true;
                return RedirectToAction("Signin", "Admin");
            }

        }
        public IActionResult EditPlace()
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {

                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int id = adminRepo.getAdminId(email1);
                List<Place> places = placeRepo.GetAllPlaces(id);
                int i = 1;
                ViewBag.x = i;
                return View("EditPlace", places);
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
            Place p = placeRepo.FindPlace(id);
            return View("Edit", p);

        }
        [HttpPost]
        public ActionResult UpdatePlace(int id,string cities, string pname, string description)
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {
                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int a_id = adminRepo.getAdminId(email1);

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
                bool result = placeRepo.updatePlace(id, cid, pname, description,a_id);
                List<Place> placesFound = placeRepo.GetAllPlaces(a_id);
                return View("EditPlace", placesFound);
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
                int a_id = adminRepo.getAdminId(email1);

                bool res = placeRepo.DeletePlace(id);

                List<Place> placesFound = placeRepo.GetAllPlaces(a_id);
                return View("EditPlace", placesFound);
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
            List<Place> placesFound = placeRepo.GetAllPlacesByCityId(id);

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
            foreach(var p in placesFound)
            {
                ids.Add(p.PlaceId);
            }
            List<PlaceImage> result = placeImageRepository.getImagesInRange(ids);
            List<List<string>> data = new List<List<string>>();
            
            int i = 0;
              foreach(var p2 in placesFound)
                {
                List<string> obj = new List<string>();
                if (result[i].PlaceId==p2.PlaceId)
                    {
                        obj.Add(p2.PlaceName);
                        obj.Add(p2.Description);
                        obj.Add(result[i].ImagePath);
                    }
                i++;
                data.Add(obj);


            }
            ViewBag.cityName = cName;
            return View("ViewAllPlaces", data);

        }
    }
}
        
