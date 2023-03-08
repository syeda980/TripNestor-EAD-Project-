using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripNestor.Models.Interfaces;

namespace TripNestor.Models
{
    public class HotelRepository:IHotel

    {
        TripNestorContext tripNestorContext = new TripNestorContext();

        public int getHotelId(string HName, int cid)
        {
            var pID = tripNestorContext.Hotels.Where(p => p.HotelName == HName && p.CityId == cid).Select(p => p.HotelId).First();
            return pID;
        }
        public List<Hotel> GetAllHotelssByCityId(int c_id)
        {
            List<Hotel> placeList = new List<Hotel>();
            var places = tripNestorContext.Hotels.Where(p => p.CityId == c_id);
            foreach (var place in places)
            {
                placeList.Add(place);

            }
            return placeList;
        }


        public bool AddToDB(int a_id, int c_id, string HName, int NoOfRooms)
        {
            Hotel Hotel = new Hotel();
            Hotel.AdminId = a_id;
            Hotel.CityId = c_id;
            Hotel.HotelName = HName;
            Hotel.NoOfRooms = NoOfRooms;
            tripNestorContext.Hotels.Add(Hotel);
            int enteries = tripNestorContext.SaveChanges();
            if (enteries > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Hotel SearchInDB(int cityId, int hotelId)
        {
            Hotel pl = new Hotel();
            var place = tripNestorContext.Hotels.Where(p => p.HotelId == hotelId);
            foreach (Hotel p in place)
            {
                if (p.HotelId == hotelId)
                {
                    pl.HotelId = hotelId;
                    pl.HotelName = p.HotelName;
                    pl.NoOfRooms = p.NoOfRooms;
                    pl.CityId = p.CityId;
                }
            }
            return pl;
        }

        public List<Hotel> GetAllHotels(int a_id)
        {
            List<Hotel> hotelList = new List<Hotel>();
            var hotels = tripNestorContext.Hotels.Where(p => p.AdminId == a_id);
            foreach (var h in hotels)
            {
                hotelList.Add(h);
            }
            return hotelList;
        }

        public Hotel FindHotel(int id)
        {
            var places = tripNestorContext.Hotels.Where(p => p.HotelId == id);
            Hotel p = new Hotel
            {
                HotelId = id,
            };
            foreach (var pl in places)
            {
                p.HotelName = pl.HotelName;
                p.NoOfRooms = pl.NoOfRooms;
            }
            return p;
        }
        public bool updateHotel(int id, int CId, string Pname, int rooms, int admin_id)
        {
            var places = tripNestorContext.Hotels.FirstOrDefault(u => u.HotelId == id);
            places.HotelId = id;
            places.HotelName = Pname;
            places.CityId = CId;
            places.NoOfRooms = rooms;

            tripNestorContext.SaveChanges();
            return true;
        }

        public bool DeleteHotel(int id)
        {
            var hotels = tripNestorContext.Hotels.FirstOrDefault(u => u.HotelId == id);
           
           tripNestorContext.Hotels.Remove(hotels);
                
            
            tripNestorContext.SaveChanges();

            return true;

        }

    }
}

