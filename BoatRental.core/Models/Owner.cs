using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class Owner : User
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Offer> Offers { get; set; }
    }
}
