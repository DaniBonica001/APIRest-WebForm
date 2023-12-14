using APIRest_WebForm.DTO;
using APIRest_WebForm.Models;

namespace APIRest_WebForm.Services
{
    public interface IPersonService
    {
        Task<String> Register(PersonaDTO personDTO);
        Task<PersonaDTO> GetPersonDetails(Guid id);
        
    }
}
