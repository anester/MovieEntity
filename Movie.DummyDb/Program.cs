using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql;
using Movie.Db;
using System.Linq;

namespace Movie.DummyDb
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieContextFactory factory = new MovieContextFactory();
            var context = factory.CreateDbContext(new string[]{""});

            context.Persons.Add(new Person {
                FirstName = "Adam",
                LastName = "Nester",
                MiddleName = "Ruel",
                Address = new Address {
                    Line1 = "2913 Kenner Drive",
                    Line2 = "",
                    City = "Pflugerville",
                    State = "TX",
                    ZipCode = "78660"
                }
            });

            context.SaveChanges();
        }
    }
}
