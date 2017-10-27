using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql;
using Movie.Db;
using System.Linq;
using Autofac;

namespace Movie.DummyDb
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new MovieDataModule { ConnectionString= "Server=localhost;database=Movie;uid=root;pwd=password;" });
            var c = builder.Build();
            using (var ls = c.BeginLifetimeScope())
            {
                var pr = ls.Resolve<Movie.Db.Interfaces.IPersonRepo>();
                var p = pr.GetPeople("Adam", "").FirstOrDefault();
                var mvlst = pr.GetPersonsMovieList(p);
                Console.WriteLine(p.Address.Line1);
            }
            //MovieContextFactory factory = new MovieContextFactory();
            //var context = factory.CreateDbContext(new string[]{"Server=localhost;database=Movie;uid=root;pwd=password;"});

            //var adam = new Person
            //{
            //    FirstName = "Adam",
            //    LastName = "Nester",
            //    MiddleName = "Ruel",
            //    Address = new Address
            //    {
            //        Line1 = "2913 Kenner Drive",
            //        Line2 = "",
            //        City = "Pflugerville",
            //        State = "TX",
            //        ZipCode = "78660"
            //    }
            //};

            //var ashley = new Person
            //{
            //    FirstName = "Ashley",
            //    LastName = "Nester",
            //    MiddleName = "Nicole",
            //    Address = adam.Address
            //};

            //var anester = new User
            //{
            //    Person = adam,
            //    PasswordHash = "",
            //    UserName = "anester"
            //};

            //var teacupnester = new User
            //{
            //    Person = ashley,
            //    PasswordHash = "",
            //    UserName = "teacupnester"
            //};


            //context.Persons.Add(adam);
            //context.Persons.Add(ashley);
            //context.Users.Add(anester);
            //context.Users.Add(teacupnester);

            //var movie1 = new Movie.Db.Movie
            //{
            //    Name = "Pirates of the Carabean",
            //    Description = "Pirates!!!",
            //    Release = DateTime.Now
            //};
            //context.Movies.Add(movie1);
            //var movie2 = new Movie.Db.Movie
            //{
            //    Name = "Assasins Creed",
            //    Description = "Assassins!!!",
            //    Release = DateTime.Now
            //};
            //context.Movies.Add(movie2);
            //var movie3 = new Movie.Db.Movie
            //{
            //    Name = "Wonder Woman",
            //    Description = "That Ass!!!",
            //    Release = DateTime.Now
            //};
            //context.Movies.Add(movie3);
            //var media = new Media
            //{
            //    Movie = movie1,
            //    MediaType = MediaTypeEnum.BluRay,
            //    Location = new Location
            //    {
            //        Address = adam.Address,
            //        LocationType = LocationTypeEnum.Physical,
            //        Description = "Upstairs",
            //        Name = "Adams House"
            //    },
            //    User = anester
            //};
            //context.Medias.Add(media);
            //var media1 = new Media
            //{
            //    Movie = movie2,
            //    MediaType = MediaTypeEnum.BluRay,
            //    Location = media.Location,
            //    User = anester
            //};

            
            //context.Medias.Add(media1);
            //context.SaveChanges();
        }
    }
}
