using APIRest_WebForm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace APIRest_WebForm.Controllers
{

    [ApiController]
    [Route("api/personas/")]
    public class PersonasController : Controller
    {
        private readonly webUsersContext dbContext;

        public PersonasController(webUsersContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register()
        {
           
            return Ok();
        }

        [HttpGet]
        [Route("details/{id:Guid}")]
        public async Task<IActionResult> GetPersonDetails([FromRoute] Guid id)
        {
            var person = await dbContext.Personas.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
    }
}
