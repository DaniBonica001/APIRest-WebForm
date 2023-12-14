using APIRest_WebForm.Data;
using APIRest_WebForm.DTO;
using APIRest_WebForm.Mapper;
using APIRest_WebForm.Models;

namespace APIRest_WebForm.Services.UsuarioServices
{
    public class UserServiceImpl : IUserService
    {
        private readonly webUsersContext dbContext;

        public UserServiceImpl(webUsersContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<UsuarioDTO> Login(LoginDTO loginDTO)
        {
            var userExists = await dbContext.Usuarios.FindAsync(loginDTO.username);
            
            if (userExists != null)
            {
                return UsuarioMapper.FromUsuarioToUsuarioDTO(userExists);
            }
            else
            {
                return new()
                {
                    Username = "",
                    Password = "",
                };

            }
        }
    }
}
