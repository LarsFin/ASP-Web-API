using System;
using ASPAPI.Models;

namespace ASPAPI.DataAccess
{
    public interface IPersonDataAccess
    {
        Person getPerson(int id);
    }
}
