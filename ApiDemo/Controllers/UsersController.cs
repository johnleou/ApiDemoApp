using ApiDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public string GetUsers()
        {
            return "Reading all the users";
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string GetUserById(int id)
        {
            return $"Reading user with id = {id}";
        }

        // POST api/<UsersController>
        [HttpPost]
        public string CreateUser([FromBody]UserModel user)
        {
            return $"Creating a user with UserId: {user.UserId} and Age: {user.Age}";
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public string UpdateUser(int id)
        {
            return $"Updating shirt: {id}";
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public string DeleteUser(int id)
        {
            return $"Delete User with id = {id}";
        }
        
    }
}
