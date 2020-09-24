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
                return StatusCode(500, "Something went wrong: " + e);
            }

            
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            try
            { 
                var pet = _petservice.GetPetById(id);
                if (pet == null)
                {
                    return StatusCode(404, "Pet with ID: " + id + " not found");
                }
                return Ok(pet);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // POST api/<PetsController>
        [HttpPost]
        public ActionResult<Pet> Post([FromBody] Pet pet)
        {
            try
            {

                if(string.IsNullOrEmpty(pet.Name))
                {
                    BadRequest("Name is required to create a pet");
                }
                if (pet.PetType == null)
                {
                    BadRequest("Pet type is required to create a pet");
                }
                return StatusCode(201, _petservice.CreatePet(pet));
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] Pet pet)
        {
            try
           {

                if(id < 1 || id != pet.Id)
                {
                    return BadRequest("Id's need to match!");
                }

                var editPet = _petservice.EditPet(pet);
                if(editPet == null)
                {
                    return StatusCode(404, "Pet with ID: " + id + " not found");
                }

                
                return StatusCode(202, editPet);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }

        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            try { 

                var pet = _petservice.DeletePet(id);
                if (pet == null)
                {
                    return StatusCode(404, "Pet with ID: " + id + " not found");
                }
            
                return StatusCode(202, $"Pet with ID: {id} is deleted");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }
    }
}
