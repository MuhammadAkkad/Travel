using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class TripDbContext:DbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options):base(options) // MovieDbContext - DbContextOptions - MovieDbContext
        {

        }
        public DbSet<Trip> Trips { get; set; } // Movies
        public DbSet<Category> Categories { get; set; }
        public DbSet<TripCategory> TripCategories { get; set; } // MovieCategories

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TripCategory>().HasKey(pk => new { pk.CategoryId, pk.TripId }); // MovieId
        }

    }
}
// done