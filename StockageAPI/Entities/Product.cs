using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public string Area { get; set; }
        public string Soort { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
    }
}
