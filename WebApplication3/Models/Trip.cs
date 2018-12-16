using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Trip
    {
        public int TripId { get; set; }//TripID // MoiveId
        public string City { get; set; }//City // Name
        public string Desc { get; set; }
        public string Famous { get; set; } //the famous thing's name
        public string FamousSubTitle { get; set; } // a brif text about it
        public string Country { get; set; }
        public int Price { get; set; }



        public List<TripCategory> TripCategories { get; set; } // MovieCategory - MovieCategories
    }
}
