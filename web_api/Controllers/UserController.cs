using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web_api.Repository;
using web_api.Models;

namespace web_api.Controllers 
{   
    [Route("api/[Controller]")]
    public class UserController : Controller {

        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepo) 
        {
            _userRepository = userRepo;
        }

        [HttpGet]
        public IEnumerable<User> GetAll() 
        {
            return _userRepository.GetAll();
        }

        [HttpGet("{id}", Name="GetUser")]
        public IActionResult GetById(long id)
        {
            var user = _userRepository.Find(id);
            if(user == null) 
            {
                return NotFound();
            }
            return new ObjectResult(user);
        }
    }
}