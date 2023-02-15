
using _2_SERVICES.Interfaces;
using _3_REPOSITORY.Entities;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1_Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<User> _user;

        public UserController(IService<User> user)
        {
            _user = user;
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _user.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async void Post([FromBody] User postUser)
        {
            User newUser= new User();
            newUser.FirstName=postUser.FirstName;
            newUser.LastName=postUser.LastName; 
            newUser.PersonalNumber=postUser.PersonalNumber;
            newUser.Gender=postUser.Gender; 
            newUser.Status=postUser.Status;
            newUser.HMO=postUser.HMO;
            newUser.Dateofbirth=postUser.Dateofbirth;
        }

        // PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
