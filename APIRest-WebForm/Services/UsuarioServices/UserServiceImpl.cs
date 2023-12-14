using APIRest_WebForm.Data;
using APIRest_WebForm.DTO;
using APIRest_WebForm.Mapper;
using APIRest_WebForm.Models;
using Microsoft.EntityFrameworkCore;

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
            var userExists = await dbContext.Usuarios.FirstOrDefaultAsync(u => u.Usuario1 == loginDTO.username);

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
