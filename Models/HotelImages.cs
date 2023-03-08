using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class HotelImages:FullAuditModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // public int Id { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Hotel")]
        public virtual int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }
    }
}
