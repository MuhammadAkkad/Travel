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
            return View(context.Trips.ToList());
        }
        public IActionResult Details(int id)
        {
            return View(context.Trips.FirstOrDefault(i=>i.TripId==id));
        }
        public IActionResult Filter(int cid)
        {
            var trips = from m in context.Trips
                         join mc in context.TripCategories
                         on m.TripId equals mc.TripId
                         where mc.CategoryId == cid
                         select m;

            return View("Index", trips.ToList());
        }
    }
}
