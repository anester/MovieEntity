using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Movie.Db
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies{get;set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations{get;set;}
        public DbSet<Media> Medias{get;set;}
        public DbSet<Person> Persons{get;set;}
        public MovieContext(DbContextOptions<MovieContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.HasDefaultSchema(schema: "Movie");
            base.OnModelCreating(modelBuilder);
        }
    }
}
