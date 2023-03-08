using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class Hotel:FullAuditModel
    {
        [Key]
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public int NoOfRooms { get; set; }

        [Display(Name = "City")]
        public virtual int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [Display(Name = "Admin")]
        public virtual int AdminId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }
        public virtual List<HotelImages> HotelImages { get; set; } = new List<HotelImages>();


    }
}
