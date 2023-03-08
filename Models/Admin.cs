using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TripNestor.Models
{
    public class Admin : FullAuditModel
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //1-many relation
        public virtual List<Place> Places { get; set; } = new List<Place>();
    }
}
