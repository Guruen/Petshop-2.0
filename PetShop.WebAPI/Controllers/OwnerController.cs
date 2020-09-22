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
    public class OwnerController : ControllerBase
    {

        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/<OwnerController>
        [HttpGet]
        public ActionResult<List<Owner>> Get([FromQuery] String name)
        {
            try
            {
                  return Ok(_ownerService.GetOwners(name));
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            try
            {
                var owner = _ownerService.GetOwnerByIdIncludingPets(id);
                if (owner == null)
                {
                    return StatusCode(404, "Owner with ID: " + id + " not found");
                }
                return Ok(owner);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
            try
            {
                if (string.IsNullOrEmpty(owner.name))
                {
                    BadRequest("Name is required to create an owner");
                }

                return StatusCode(201, _ownerService.CreateOwner(owner));

            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, [FromBody] Owner owner)
        {
            try
            {

                if (id < 1 || id != owner.Id)
                {
                    return BadRequest("Id's need to match!");
                }

                var editOwner = _ownerService.EditOwner(owner);
                if (editOwner == null)
                {
                    return StatusCode(404, "Owner with ID: " + id + " not found");
                }


                return StatusCode(202, editOwner);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }


        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {
            try
            {
                var owner = _ownerService.DeleteOwner(id);
                if (owner == null)
                {
                    return StatusCode(404, "Owner with ID: " + id + " not found");
                }

                return StatusCode(202, "Owner with ID: {id} is deleted");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }
    }
}
