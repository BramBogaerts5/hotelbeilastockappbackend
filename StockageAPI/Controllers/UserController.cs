using Microsoft.AspNetCore.Mvc;
using StockageAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockageAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserData _userData;

        public UserController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userData.GetAll());
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_userData.GetById(id));
        }

        [Route("name/{name}")]
        [HttpGet]
        public IActionResult GetByName(string name)
        {
            return Ok(_userData.GetByName(name));
        }


    }
}
