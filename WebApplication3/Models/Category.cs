using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Continent { get; set; }

        public List<TripCategory> TripCategories { get; set; }

    }
}
