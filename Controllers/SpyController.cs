using Microsoft.AspNetCore.Mvc;
using SpyDuhCatWoman.Models;
using SpyDuhCatWoman.Repositories;
using SpyDuhCatWoman.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpyDuhCatWoman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {
        public SpyController(ISpyRepository SpyRepository)
        {
            _spyRepo = SpyRepository;
        }

        private ISpyRepository _spyRepo;

        

        // GET: api/<SpyController>
        [HttpGet] //GetSpies() - returns a list of all spies
        public List<Spy> GetAllSpies()
        {
            return _spyRepo.GetAll();
        }

        // GET api/<SpyController>/5
        [HttpGet("/api/Spy/{id}")] //GetSpy() - returns specific spies information
        public Spy Get(int id)
        {
            return _spyRepo.GetById(id); //_spyRepo.GetById();
        }

        // GET api/<SpyController>/5
        [HttpGet("/api/Spy/user/{skill}")] //GetSpy() - returns specific spies information
        public List<Spy> GetBySkill(string skill)
        {
            return _spyRepo.GetBySkill(skill); //_spyRepo.GetBySkill();
        }

        // POST api/<SpyController>
        [HttpPost] //CreateSpy(Spy newSpy) - adds a new spy to the database
        public void Post([FromBody] Spy newSpy)
        {
            _spyRepo.CreateSpy(newSpy);
        }


        // POST API New Service
        [HttpPost("{id}/services")] //AddServices(string service) - adds a new to service to the current spies services list
        public void PostNewServices(int id, [FromBody] string value)
        {
            _spyRepo.PostService(value, id);
        }

        // POST API New Skll
        [HttpPost("{id}/skills")] //AddServices(string service) - adds a new to service to the current spies services list
        public void PostNewSkill(int id, [FromBody] string value)
        {
            _spyRepo.PostSkill(value, id);
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

