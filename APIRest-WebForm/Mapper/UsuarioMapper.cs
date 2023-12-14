using APIRest_WebForm.DTO;
using APIRest_WebForm.Models;

namespace APIRest_WebForm.Mapper
{
    public class UsuarioMapper
    {

        public static UsuarioDTO FromUsuarioToUsuarioDTO(Usuario usuario)
        {
            return new UsuarioDTO
            {
                Username = usuario.Usuario1,
                Password = usuario.Pass,
                FechaCreacion = usuario.FechaCreacion
            };
        }   
    }
}
