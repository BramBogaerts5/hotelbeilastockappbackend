using StockageAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Services.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Product GetByName(string name);
        Product GetByKind(string soort);
        IEnumerable<Product> GetByArea(string area);
        void Update(int oldProductId, Product newProduct);
    }
}
