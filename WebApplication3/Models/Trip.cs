using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string City { get; set; }
        public string Desc { get; set; }
        public string Famous { get; set; }
        public string FamousSubTitle { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }



        public List<TripCategory> TripCategories { get; set; }
    }
}
// done