using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class HotelImageRepository
    {
        TripNestorContext tripNestorContext = new TripNestorContext();
        public bool AddToDB(int id, List<string> Imgpaths)
        {
            int enteries = -1;
            HotelImages hotelImage = new HotelImages();
            hotelImage.HotelId = id;
            foreach (var path in Imgpaths)
            {
                hotelImage.ImagePath = path;
                tripNestorContext.HotelImages.Add(hotelImage);
                enteries = tripNestorContext.SaveChanges();
            }
            if (enteries > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<HotelImages> getImages(int id)
        {
            var pImg = tripNestorContext.HotelImages.Where(p => p.HotelId == id).ToList();
            return pImg;
        }
        public List<HotelImages> getImagesInRange(List<int> ids)
        {
            var result = (from data in tripNestorContext.HotelImages 
                          where ids.Contains(data.HotelId) // replace "Id" with the name of your ID column
                          select data).ToList();
            return result;
        }
    }
}
