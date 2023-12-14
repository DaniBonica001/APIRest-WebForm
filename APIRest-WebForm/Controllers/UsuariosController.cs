using Microsoft.AspNetCore.Mvc;

namespace APIRest_WebForm.Controllers
{

    [ApiController]
    [Route("api/usuarios/")]
    public class UsuariosController : Controller
    {

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }   
        
    }
}
