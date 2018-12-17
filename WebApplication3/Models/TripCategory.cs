using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class TripCategory
    {
        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}