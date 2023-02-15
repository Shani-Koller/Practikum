using _2_SERVICES.Interfaces;
using _2_SERVICES.Models;
using _2_SERVICES.Services;
using _3_REPOSITORY;
using _3_REPOSITORY.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildService _child;
        private readonly DataSource _dataSource;

        public ChildrenController(IChildService childService, DataSource dataSource)
        {
            _child = childService;
            _dataSource = dataSource;
        }
        // GET: api/<ChildrenController>
        [HttpGet]
        public async Task<List<ChildModel>> Get()
        {
            return await _child.GetAllAsync();
        }

        // GET api/<ChildrenController>/5
        [HttpGet("{id}")]
        public async Task<List<ChildModel>> Get(int id)
        {
            return await _child.GetAllAsync();
        }

        // POST api/<ChildrenController>
        [HttpPost]
        public async Task<ChildModel> Post([FromBody] ChildModel postChild)
        {
       
            
            ChildModel newChild = new ChildModel();
            newChild.Id = postChild.Id;
            newChild.Name = postChild.Name;
            newChild.Parent = postChild.Parent;
            newChild.ParentId = postChild.ParentId;
            newChild.PersonalNumber = postChild.PersonalNumber;
            newChild.BirthDate = postChild.BirthDate;
            return await _child.AddAsync(newChild);
        }

        //// PUT api/<ChildrenController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ChildrenController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _child.DeleteAsync(id);
        }
    }
}
