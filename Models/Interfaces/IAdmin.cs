using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models.Interfaces
{
    public interface IAdmin
    {
        public Admin checkAdminExist(Admin a);
        public int getAdminId(string adminEmail);

    }
}
