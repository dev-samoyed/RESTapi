using Microsoft.EntityFrameworkCore;
using RESTapi.Data.Entities;
using System;

namespace RESTapi.Data
{
    public class AppContext : DbContext
    {

        /* DbSets */
        public DbSet<City> Cities { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

        public AppContext(DbContextOptions<AppContext> options)
           : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
