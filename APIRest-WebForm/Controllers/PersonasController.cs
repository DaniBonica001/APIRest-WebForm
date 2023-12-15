using APIRest_WebForm.Data;
using APIRest_WebForm.DTO;
using APIRest_WebForm.Mapper;
using APIRest_WebForm.Models;
using APIRest_WebForm.Services.PersonaServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace APIRest_WebForm.Controllers
{

    [ApiController]
    [Route("api/personas/")]
    public class PersonasController : Controller
    {
        private readonly IPersonService personService;

        public PersonasController(IPersonService personService)
        {
            this.personService = personService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]PersonaDTO personDTO)
        {
            
            return Ok(await personService.Register(personDTO));
          
        }

        [HttpGet]
        [Route("details/{id:Guid}")]
        public async Task<IActionResult> GetPersonDetails([FromRoute] Guid id)
        {
            PersonaDTO person = await personService.GetPersonDetails(id);
            if (person != null)
            {
                return Ok(person);
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
