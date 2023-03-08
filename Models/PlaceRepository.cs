using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripNestor.Models.Interfaces;

namespace TripNestor.Models
{
    public class PlaceRepository:IPlace
    {
        
        TripNestorContext tripNestorContext = new TripNestorContext();

        public int getPlaceId(string placeName, int cid)
        {
            var pID = tripNestorContext.Places.Where(p => p.PlaceName == placeName && p.CityId==cid).Select(p => p.PlaceId).ToList();
            if (pID.Count > 0)
            {
                
                return pID[0];
            }
            else
            {
                return -1;
            }
        }

        public Place SearchInDB(int cityId, int placeId)
        {
            Place pl = new Place();
            var place = tripNestorContext.Places.Where(p => p.PlaceId == placeId);
            foreach (Place p in place)
            {
                if (p.PlaceId == placeId)
                {
                    pl.PlaceId = placeId;
                    pl.PlaceName = p.PlaceName;
                    pl.Description = p.Description;
                    pl.CityId = p.CityId;
                }
            }
            return pl;
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

        public List<Place> GetAllPlaces(int a_id)
        {
            List<Place> placeList = new List<Place>();
            var places = tripNestorContext.Places.Where(p => p.AdminId == a_id) ;
            foreach (var place in places)
            {
                placeList.Add(place);

            }
            return placeList;
        }
        public List<Place> GetAllPlacesByCityId(int c_id)
        {
            List<Place> placeList = new List<Place>();
            var places = tripNestorContext.Places.Where(p => p.CityId == c_id);
            foreach (var place in places)
            {
                placeList.Add(place);

            }
            return placeList;
        }


        public Place FindPlace(int id)
        {
            var places = tripNestorContext.Places.Where(p => p.PlaceId == id);
            Place p = new Place
            {
                PlaceId = id,
            };
            foreach(var pl in places)
            {
                p.PlaceName = pl.PlaceName;
                p.Description = pl.Description;
            }
            return p;

        }
        public bool updatePlace(int id,int CId,string Pname,string description,int admin_id)
        {
            var places = tripNestorContext.Places.FirstOrDefault(u => u.PlaceId ==id);
                places.PlaceId = id;
                places.PlaceName = Pname;
                places.CityId = CId;
                places.Description = description;
            
            tripNestorContext.SaveChanges();
            return true;
        }
        
        public bool DeletePlace(int id)
        {
            var places = tripNestorContext.Places.Where(u => u.PlaceId == id);
           // var placeImages = tripNestorContext.PlaceImages.Where(u => u.PlaceId == id);
          /*  foreach (PlaceImage pI in placeImages)
            {
                if (pI.PlaceId == id)
                {
                    tripNestorContext.PlaceImages.(pI);
                }
            }
          */  foreach (Place p in places)
            {
                if (p.PlaceId == id)
                {
                    tripNestorContext.Places.Remove(p);
                }
            }
            tripNestorContext.SaveChanges();
            
            return true;

        }

    }
}
