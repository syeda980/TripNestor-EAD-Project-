using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models
{
    public class PlaceImage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Place")]
        public virtual int PlaceId { get; set; }

        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }

    }
}
