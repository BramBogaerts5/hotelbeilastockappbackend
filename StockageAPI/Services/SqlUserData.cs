using StockageAPI.Context;
using StockageAPI.Entities;
using StockageAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Services
{
    public class SqlUserData : IUserData
    {
        private StockageContext _context;

        public SqlUserData(StockageContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.OrderBy(u => u.UserId).ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == id);
        }

        public User GetByName(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name);
        }
    }
}
