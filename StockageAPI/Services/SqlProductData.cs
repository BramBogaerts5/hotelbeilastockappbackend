using StockageAPI.Context;
using StockageAPI.Entities;
using StockageAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Services
{
    public class SqlProductData : IProductData
    {
        private StockageContext _context;

        public SqlProductData(StockageContext context)
        {
            _context = context;
        }

        public void Add(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Products.Where(d => d.ProductId == id)
                .ToList()
                .RemoveAll(d => d.ProductId == id);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.OrderBy(d => d.ProductId).ToList();
        }

        public IEnumerable<Product> GetByArea(string area)
        {
            return _context.Products.OrderBy(d => d.ProductId).Where(e => e.Area == area).ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(d => d.ProductId == id);
        }

        public Product GetByKind(string soort)
        {
            return _context.Products.FirstOrDefault(d => d.Soort == soort);
        }

        public Product GetByName(string name)
        {
            return _context.Products.FirstOrDefault(d => d.Name == name);
        }

        public void Update(int oldProductId, Product newProduct)
        {
            _context.Products.Where(d => d.ProductId == oldProductId)
                .ToList()
                .ForEach(d => d = newProduct);
            _context.SaveChanges();
        }
    }
}
