using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Db.Interfaces
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetPeople(string firstname, string lastname);
        IEnumerable<User> GetUser(string username);
        IEnumerable<Media> LoadMedia(Person person);
        IEnumerable<Movie> GetPersonsMovieList(Person person);
    }
}
