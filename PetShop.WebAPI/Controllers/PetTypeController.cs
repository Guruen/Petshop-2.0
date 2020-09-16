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
                return Ok(_petTypeService.GetPetType());
            }
            catch (Exception e)
            {
                return StatusCode(500, "Something went wrong: " + e);
            }
        }

        // GET api/<PetTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
