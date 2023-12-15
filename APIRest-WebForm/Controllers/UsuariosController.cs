using APIRest_WebForm.DTO;
using APIRest_WebForm.Services.UsuarioServices;
using Microsoft.AspNetCore.Mvc;

namespace APIRest_WebForm.Controllers
{

    [ApiController]
    [Route("api/usuarios/")]
    public class UsuariosController : Controller
    {
        private readonly IUserService userService;

        public UsuariosController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            return Ok(await userService.Login(loginDTO));
        }   
        
    }
}
