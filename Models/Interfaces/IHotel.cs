using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models.Interfaces
{
    interface IHotel
    {
        public int getHotelId(string HName, int cid);
        public bool AddToDB(int a_id, int c_id, string HName, int NoOfRooms);
        public List<Hotel> GetAllHotels(int a_id);
        public Hotel FindHotel(int id);
        public bool updateHotel(int id, int CId, string Pname, int rooms, int admin_id);
        public bool DeleteHotel(int id);

    }
}
