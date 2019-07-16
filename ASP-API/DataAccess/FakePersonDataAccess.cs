using System;
using System.Collections.Generic;
using System.Linq;
using ASPAPI.Models;

namespace ASPAPI.DataAccess
{
    public class FakePersonDataAccess : IPersonDataAccess
    {
        IList<Person> people = new List<Person>();

        public Person getPerson(int id)
        {
            return people.SingleOrDefault(q => q.Id.Equals(id));
        }
    }
}
