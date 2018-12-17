using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Continent { get; set; } // Name

        public List<TripCategory> TripCategories { get; set; }  // MovieCategory - MovieCategories

    }
}
// done