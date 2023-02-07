using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class PlaceImageRepository
    {
        TripNestorContext tripNestorContext = new TripNestorContext();
        public bool AddToDB(int id,List<string> Imgpaths)
        {
            int enteries = -1;
            PlaceImage placeImage = new PlaceImage();
            placeImage.PlaceId = id;
            foreach (var path in Imgpaths)
            {
                placeImage.ImagePath = path;
                tripNestorContext.PlaceImages.Add(placeImage);
                enteries = tripNestorContext.SaveChanges();
            }
            if(enteries>0)
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
