using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;

namespace TravelBlog.Controllers
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
            //context.Movies.Add(new Movie { Name = "The Godfather", Desc = "asdsa" });
            //context.SaveChanges(); 
            //Movie m = context.Movies.FirstOrDefault(i=>i.Id==1);
            //m.Name = "Esaretin Bedeli";
            //context.Movies.Update();
            //context.Save Changes();
            return View(context.Trips.ToList()); // Movies
        }
        public IActionResult Details(int id)
        {
            return View(context.Trips.FirstOrDefault(i=>i.TripId==id)); // Movies
        }
        public IActionResult Filter(int cid)
        {
            var trips = from m in context.Trips // movies - Movies
                         join mc in context.TripCategories // MovieCategories
                         on m.TripId equals mc.TripId // MovieId
                         where mc.CategoryId == cid
                         select m;

            return View("Index", trips.ToList()); // movies
        }
    }
}

// done