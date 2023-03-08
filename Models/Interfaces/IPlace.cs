using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models.Interfaces
{
    public interface IPlace
    {
        public int getPlaceId(string placeName, int cid);
        public Place SearchInDB(int cityId, int placeId);
        public List<Place> GetAllPlaces(int a_id);
        public List<Place> GetAllPlacesByCityId(int c_id);
        public Place FindPlace(int id);
        public bool updatePlace(int id, int CId, string Pname, string description, int admin_id);

        public bool DeletePlace(int id);
        public bool AddToDB(int a_id, int c_id, string PName, string description);
    }
}
