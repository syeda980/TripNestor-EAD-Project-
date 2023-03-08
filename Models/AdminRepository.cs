using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models.Interfaces;

namespace TripNestor.Models
{
    public class AdminRepository:IAdmin
    {
        TripNestorContext tripNestorContext = new TripNestorContext();
        public Admin checkAdminExist(Admin admin)
        {
            var userExist = tripNestorContext.Admins.FirstOrDefault(u => u.Email == admin.Email && u.Password == admin.Password);
            return userExist;
        }
        public int getAdminId(string adminEmail)
        {
            var uID = tripNestorContext.Admins.Where(u => u.Email == adminEmail).Select(u=>u.Id).First();
            return uID;
        }
    }
}
