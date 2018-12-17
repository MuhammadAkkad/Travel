using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class TripDbContext:DbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options):base(options)
        {

        }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TripCategory> TripCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TripCategory>().HasKey(pk => new { pk.CategoryId, pk.TripId });
        }

    }
}