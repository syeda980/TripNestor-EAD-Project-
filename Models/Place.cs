using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class Place
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string Description { get; set; }

        [Display(Name = "City")]
        public virtual int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
