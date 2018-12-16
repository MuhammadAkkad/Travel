using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        TripDbContext context;
        public HomeController(TripDbContext c)
        {
            context = c;
        }
        public IActionResult Index()
        {
            //context.Trips.Add(new Trip { City = "The Godfather", Desc = "asdsa" }); // Movies - Movie - Name
            //context.SaveChanges(); 
            //Trip m = context.Movies.FirstOrDefault(i=>i.Id==1);  // Movie
            //m.Name = "Esaretin Bedeli"; // find it 0000000000000000 ?!
            //context.Trips.Update(); // Movies
            //context.Save Changes();
            return View(context.Trips.ToList()); // Movies
        }
        public IActionResult Details(int id)
        {
            return View(context.Trips.FirstOrDefault(i=>i.TripId==id)); // Movies - MovieId
        }
        public IActionResult Filter(int cid)
        {
            var trips = from m in context.Trips //Trips // Movies
                         join mc in context.TripCategories //TripsCategories // MovieCategories
                         on m.TripId equals mc.TripId //mc.TripId // MovieId - MovieId
                         where mc.CategoryId == cid
                         select m;

            return View("Index",trips.ToList()); // movies 000000000000000000
        }
    }
}