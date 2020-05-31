using Microsoft.AspNetCore.Mvc;
using StockageAPI.Entities;
using StockageAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController:Controller
    {
        private IProductData _productData;

        public ProductController(IProductData productData)
        {
            _productData = productData;
        }

        [Route("all")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productData.GetAll());
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_productData.GetById(id));
        }

        [Route("productname/{name}")]
        [HttpGet]
        public IActionResult GetByName(string name)
        {
            return Ok(_productData.GetByName(name));
        }

        [Route("item/{area}")]
        [HttpGet]
        public IActionResult GetByArea(string area)
        {
            return Ok(_productData.GetByArea(area));
        }

        [Route("productkind/{soort}")]
        [HttpGet]
        public IActionResult GetByKind(string soort)
        {
            return Ok(_productData.GetByKind(soort));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int oldProductId, Product newProduct)
        {
            if(_productData.GetById(oldProductId) == null)
            {
                return NotFound();
            }

            _productData.Update(oldProductId, newProduct);
            return Ok();
        }
    }
}
