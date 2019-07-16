using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ASPAPI.Models;

namespace ASPAPI.Controller
{
    public class PersonController : ApiController
    {
        List<Person> people = new List<Person>{
            new Person { Id = 1, Name = "Bob", Age = 38, Address = "London" },
            new Person { Id = 2, Name = "Charlie", Age = 25, Address = "Paris" },
            new Person { Id = 3, Name = "Hammer", Age = 19, Address = "London"}
        };

        public IEnumerable<Person> GetAllPeople()
        {
            return people;
        }

        public IHttpActionResult GetPerson(int id)
        {
            var person = people.FirstOrDefault((p) => p.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}
