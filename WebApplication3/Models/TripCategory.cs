using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class TripCategory // MovieCategory
    {
        public int TripId { get; set; } // MovieId
        public Trip Trip { get; set; } // Movie - Movie

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
// done 