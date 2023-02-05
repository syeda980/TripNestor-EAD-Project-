using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class AdminRepository
    {
        TripNestorContext tripNestorContext = new TripNestorContext();
        public Admin checkAdminExist(Admin admin)
        {
            var userExist = tripNestorContext.Admins.FirstOrDefault(u => u.Email == admin.Email && u.Password == admin.Password);
            return userExist;
        }
    }
}
