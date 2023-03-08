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
        public List<PlaceImage> getImages(int id)
        {
            var pImg=tripNestorContext.PlaceImages.Where( p=> p.PlaceId == id).ToList();
            return pImg; 
        }
        public List<PlaceImage> getImagesInRange(List<int>ids)
        {
            var result = (from data in tripNestorContext.PlaceImages // replace "dbContext" and "TableName" with your specific database context and table name
                         where ids.Contains(data.PlaceId) // replace "Id" with the name of your ID column
                         select data).ToList();
            return result;
        }
    }
}
