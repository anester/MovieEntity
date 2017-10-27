using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Movie.Db.Implementation
{
    class PersonRepo : Interfaces.IPersonRepo
    {
        readonly MovieContext _context;
        public PersonRepo(MovieContext context)
        {
            _context = context;
        }

        public Person GetPerson(int personid)
        {
            return _context.Persons.AsTracking().First(p => p.PersonId == personid);
        }

        public bool UpdatePerson(Person p)
        {
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Person> GetPeople(string firstname, string lastname)
        {
            var query = _context.Persons
                           .Include(p => p.Address)
                           .Where(p => p.FirstName.Contains(firstname)
                               || p.LastName.Contains(lastname));

            return query.ToList();
        }

        public IEnumerable<Media> LoadMedia(Person person)
        {
            var col = _context.Entry(person).Collection(p => p.MediaCollection).Query().Include(m => m.Movie).ToList();
            return person.MediaCollection;
        }

        public IEnumerable<User> GetUser(string username)
        {
            return _context.Users
                           .Include(u => u.Person)
                           .Include(u => u.Person.Address)
                           .Include(u => u.Person.MediaCollection).ThenInclude(u => u.Movie)
                           .Where(u => u.UserName == username)
                           .ToList();
        }

        public IEnumerable<Movie> GetPersonsMovieList(Person person)
        {
            return _context.Persons.Where(p => p.PersonId == person.PersonId)
                           .Include(p => p.MediaCollection)
                           .ThenInclude(m => m.Movie)
                           .ToList()
                           .SelectMany(p => p.MediaCollection.Select(m => m.Movie).Distinct()).ToList();
        }
    }
}
