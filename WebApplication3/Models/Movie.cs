using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string TripSubtitle { get; set; }
        public string Continent { get; set; }
        public int price { get; set; }



        public List<MovieCategory> MovieCategories { get; set; }
    }
}
