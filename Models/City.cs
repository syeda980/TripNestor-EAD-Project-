using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class City : FullAuditModel
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int NoOfPlaces { get; set; }
        public virtual List<Place> Places { get; set; } = new List<Place>();
        public virtual List<Hotel> Hotels { get; set; } = new List<Hotel>();

    }
}
