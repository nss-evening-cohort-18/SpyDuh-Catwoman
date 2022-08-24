using Microsoft.AspNetCore.Mvc;
using SpyDuhCatWoman.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpyDuhCatWoman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {
        // GET: api/<SpyController>
        [HttpGet] //GetSpies() - returns a list of all spies
        public List<Spy> GetAllSpies()
        {
            return _spyRepo.GetAll();
        }

        // GET api/<SpyController>/5
        [HttpGet("{id}")] //GetSpy() - returns specific spies information
        public string Get(int id)
        {
            return _spyRepo.GetById();
        }

        // POST api/<SpyController>
        [HttpPost] //CreateSpy(Spy newSpy) - adds a new spy to the database
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SpyController>/5
        [HttpPut("skills")] //AddSkill(string skill) - adds a new to skill to current spies skill list
        public void PutSkills(int id, [FromBody] string value)
        {
        }


        // PUT api/<SpyController>/5
        [HttpPut("services")] //AddServices(string service) - adds a new to service to the current spies services list
        public void PutServices(int id, [FromBody] string value)
        {
        }


        // PUT api/<SpyController>/5
        [HttpPut("friends")] //AddFriend(int spyId) - adds a new spy to the users friend list
        public void PutFriends(int id, [FromBody] string value)
        {
        }


        // PUT api/<SpyController>/5
        [HttpPut("enemies")] //AddEnemy(int spyId) - adds a new spy to the users enemy list
        public void PutEnemy(int id, [FromBody] string value)
        {
        }

    }
}

