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
    public class OwnersController : ControllerBase
    {

        private readonly IOwnerService _ownerService;

        public OwnersController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/<OwnersController>
        [HttpGet]
        public ActionResult<List<Owner>> Get()
        {
            try
            {
                return Ok(_ownerService.GetOwners());
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // GET api/<OwnersController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            try
            {
                var owner = _ownerService.GetOwnerById(id);
                if (owner == null)
                {
                    return StatusCode(404, "Owner with ID: " + id + " not found");
                }
                return owner;
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // POST api/<OwnersController>
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

        // PUT api/<OwnersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OwnersController>/5
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

                return Ok($"Owner with ID: {id} is deleted");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }
    }
}
