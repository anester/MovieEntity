using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations.Design;

 
namespace Movie.Db
{
    class MovieContextFactory : IDesignTimeDbContextFactory<MovieContext>
    {
        public MovieContext CreateDbContext(string[] args)
        {
           var builder = new DbContextOptionsBuilder<MovieContext>();
            builder.UseMySql( args.Length > 0 ? args[0] :
                "Server=localhost;database=Movie;uid=root;pwd=password;");
 
            return new MovieContext(builder.Options);
        }
    }
}