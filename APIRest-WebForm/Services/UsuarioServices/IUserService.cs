using APIRest_WebForm.DTO;

namespace APIRest_WebForm.Services.UsuarioServices
{
    public interface IUserService
    {
        Task<UsuarioDTO> Login(LoginDTO loginDTO);
    }
}
