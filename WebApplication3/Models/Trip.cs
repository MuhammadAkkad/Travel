using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class Trip
    {
        public int TripId { get; set; } // MovieId
        public string City { get; set; } // Name
        public string Desc { get; set; }
        public string Famous { get; set; } //the famous thing's name
        public string FamousSubTitle { get; set; } // a brif text about it
        public string Country { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }



        public List<TripCategory> TripCategories { get; set; } // MovieCategory - MovieCategories
    }
}
// done