using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripNestor.Models
{
    public class PlaceRepository
    {
        TripNestorContext tripNestorContext = new TripNestorContext();

        public int getPlaceId(string placeName, int cid)
        {
            var pID = tripNestorContext.Places.Where(p => p.PlaceName == placeName && p.CityId==cid).Select(p => p.PlaceId).First();
            return pID;
        }


        public bool AddToDB(int a_id, int c_id,string PName, string description)
        {
            Place place = new Place();
            place.AdminId = a_id;
            place.CityId = c_id;
            place.PlaceName = PName;
            place.Description = description;
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

        }


    }
}
