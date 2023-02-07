using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripNestor.Models.Interfaces
{
    public interface IActivatableModel
    {
        public bool IsActive { get; set; }
    }
}
