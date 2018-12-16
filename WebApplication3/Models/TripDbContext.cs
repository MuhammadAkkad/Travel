using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class TripDbContext: DbContext // MovieDbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options):base(options) // MovieDbContext
        {

        }
        public DbSet<Trip> Trips { get; set; } // Movie - Movies
        public DbSet<Category> Categories { get; set; }
        public DbSet<TripCategory> TripCategories { get; set; }  //MovieCategory - TripCategories

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TripCategory>().HasKey(pk => new { pk.CategoryId, pk.TripId }); // MovieCategory
        }

    }
}
