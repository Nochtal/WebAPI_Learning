using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// WebAPI for accessing information about peeps
    /// </summary>
    public class PeopleController : ApiController
    {
        // Acting database for testing. Database calls should happen in a class library,
        // not in the API, the following is a simulated result List from a database.
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FName = "Jeff", LName = "H", Id = 1 });
            people.Add(new Person { FName = "Greg", LName = "H", Id = 2 });
            people.Add(new Person { FName = "Dennis", LName = "LC", Id = 3 });
        }

        // Utilized Postman for testing API

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <returns>List<string>FirstName</string></returns>
        [Route("api/People/GetFirstNames")] // override default route
        [HttpGet] // Tell what types of commands to utilize
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FName);
            }

            return output;
        }

        /// <summary>
        /// Gets full list of people
        /// </summary>
        /// <returns>People, displays Id, First Name, Last Name for each person</returns>
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            // would normally add verification of data before adding it.
            people.Add(val);
            // Will not be returned in a new Get, as new PeopleController is 
            // instantiated on each call
            // Do not pass this data through the URL
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            // Most APIs utilized for games will not have access
            // to a delete command.
            // Usually send id to middle tier database Class Library
            // for which row(s) to remove from the database.
        }
    }
}
