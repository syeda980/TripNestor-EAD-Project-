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
    public class PlaceController : Controller
    {
        PlaceRepository placeRepository = new PlaceRepository();
        AdminRepository adminRepository = new AdminRepository();
        PlaceImageRepository placeImageRepository = new PlaceImageRepository();
        private readonly IWebHostEnvironment Environment;

        public PlaceController(IWebHostEnvironment
            environment)
        {

            Environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult addPlace()
        {
            return View("addPlace");
        }


        public string addPlacetoDB(List<IFormFile> postedFiles, string cities,string pname,string description)
        {
            if (HttpContext.Request.Cookies.ContainsKey("adminEmail"))
            {
                var email = Request.Cookies["adminEmail"];
                string email1 = email.ToString();
                int id = adminRepository.getAdminId(email1);

                int cid =0;
                string cName = "";
                if(cities=="1")
                {
                    cid = 1;
                    cName = "Lahore";

                }
                else if(cities=="2")
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
                    fileNames.Add(pathWithFileName);
                    using (FileStream stream = new
                        FileStream(pathWithFileName,
                        FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                bool result=placeRepository.AddToDB(id,cid, pname, description);

                int placeId = placeRepository.getPlaceId(pname,cid);
                if(result==true)
                {
                    bool res=placeImageRepository.AddToDB(placeId, fileNames);
                    if (res == true)
                    {
                        return "added in db table";
                    }
                    else
                    {
                        return "not addded in images";
                    }
                }
                else
                {
                    return "not added";
                }

            }
            else
            {
                return "please login first";
            }

        }
    }
}
