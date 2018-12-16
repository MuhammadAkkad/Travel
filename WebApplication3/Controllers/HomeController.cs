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
        MovieDbContext context;
        public HomeController(MovieDbContext c)
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
            return View(context.Movies.ToList());
        }
        public IActionResult Details(int id)
        {
            return View(context.Movies.FirstOrDefault(i=>i.MovieId==id));
        }
        public IActionResult Filter(int cid)
        {
            var movies = from m in context.Movies
                         join mc in context.MovieCategories
                         on m.MovieId equals mc.MovieId
                         where mc.CategoryId == cid
                         select m;

            return View("Index",movies.ToList());
        }
    }
}