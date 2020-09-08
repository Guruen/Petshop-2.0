using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Core.ApplicationService;
using PetShop.Core.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petservice;

        public PetsController(IPetService petService)
        {
            _petservice = petService;
        }

        // GET: api/<PetsController>
        [HttpGet]
        public ActionResult<List<Pet>> Get()
        {
            try
            {
                return Ok(_petservice.GetPets());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] Pet pet)
        {
            _petservice.CreatePet(pet);
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
