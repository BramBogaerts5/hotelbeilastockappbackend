using StockageAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Services.Interfaces
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User GetByName(string name);
    }
}
