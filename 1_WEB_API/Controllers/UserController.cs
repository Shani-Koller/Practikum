
using _2_SERVICES.Interfaces;
using _2_SERVICES.Models;
using _3_REPOSITORY;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1_Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private  IUserService _user;
        private readonly DataSource _dataSource;
        public UserController(IUserService user, DataSource dataSource)
        {
            _user = user;
            _dataSource=dataSource; 
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserModel>> Get()
        {
            return await _user.GetAllAsync();
        }

        // GET api/<UserController>/5Save
        [HttpGet("{id}")]
        public async Task<UserModel> Get(int id)
        {
            return await _user.GetByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel postUser)
        {
            UserModel newUser = new UserModel();
            newUser.FirstName=postUser.FirstName;
            newUser.LastName=postUser.LastName; 
            newUser.PersonalNumber=postUser.PersonalNumber;
            newUser.Gender=postUser.Gender; 
            newUser.HMO=postUser.HMO;
            newUser.Dateofbirth=postUser.Dateofbirth;
            newUser.children=postUser.children; 
            return await _user.AddAsync(newUser);
        

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _user.DeleteAsync(id);
        }
    }
}
