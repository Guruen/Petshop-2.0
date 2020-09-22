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
    public class PetTypeController : ControllerBase
    {

        private readonly IPetTypeService _petTypeService;

        public PetTypeController(IPetTypeService petTypeService)
        {
            _petTypeService = petTypeService;
        }

        // GET: api/<PetTypeController>
        [HttpGet]
        public ActionResult<List<PetType>> Get()
        {
            try
            {
                return Ok(_petTypeService.GetPetType().ToList());
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // GET api/<PetTypeController>/5
        [HttpGet("{id}")]
        public ActionResult<PetType> Get(int id)
        {
            try
            {
                var petType = _petTypeService.GetPetTypeById(id);
                if (petType == null)
                {
                    return StatusCode(404, "Pet Type with ID: " + id + " not found");
                }
                return Ok(petType);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // POST api/<PetTypeController>
        [HttpPost]
        public ActionResult<PetType> Post([FromBody] PetType petType)
        {
            try
            {

                if (string.IsNullOrEmpty(petType.name))
                {
                    BadRequest("Name is required to create a Pet Type");
                }


                return StatusCode(201, _petTypeService.CreatePetType(petType));
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }

        }

        // PUT api/<PetTypeController>/5
        [HttpPut("{id}")]
        public ActionResult<PetType> Put(int id, [FromBody] PetType petType)
        {
            try
            {

                if (id < 1 || id != petType.Id)
                {
                    return BadRequest("Id's need to match!");
                }

                var editPetType = _petTypeService.EditPetType(petType);
                if (editPetType == null)
                {
                    return StatusCode(404, "Pet type with ID: " + id + " not found");
                }


                return StatusCode(202, editPetType);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }

        }

        // DELETE api/<PetTypeController>/5
        [HttpDelete("{id}")]
        public ActionResult<PetType> Delete(int id)
        {
            try
            {
                var petType = _petTypeService.DeletePetType(id);
                if (petType == null)
                {
                    return StatusCode(404, "Pet Type with ID: " + id + " not found");
                }

                return StatusCode(202, $"Pet Type with ID: {id} is deleted");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }
    }
}
