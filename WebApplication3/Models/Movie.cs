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
        public string Famous { get; set; } //the famous thing's name
        public string FamousSubTitle { get; set; } // a brif text about it
        public string Country { get; set; }
        public int Price { get; set; }



        public List<MovieCategory> MovieCategories { get; set; }
    }
}
