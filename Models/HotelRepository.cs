using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class HotelRepository
    {
        TripNestorContext tripNestorContext = new TripNestorContext();

        public int getHotelId(string HName, int cid)
        {
            var pID = tripNestorContext.Hotels.Where(p => p.HotelName == HName && p.CityId == cid).Select(p => p.Id).First();
            return pID;
        }


        //public bool AddToDB(int a_id, int c_id, string HName, int NoOfRooms)
        //{
          /*  Hotel Hotel = new Hotel();
            Hotel. = a_id;
            place.CityId = c_id;
            place.PlaceName = HName;
            place.No = NoOfRooms;
            tripNestorContext.Places.Add(place);
            int enteries = tripNestorContext.SaveChanges();
            if (enteries > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
*/
        //}


    }
}

