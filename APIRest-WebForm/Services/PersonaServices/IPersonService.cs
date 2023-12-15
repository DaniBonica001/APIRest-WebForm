using APIRest_WebForm.DTO;
using APIRest_WebForm.Models;

namespace APIRest_WebForm.Services.PersonaServices
{
    public interface IPersonService
    {
        Task<string> Register(PersonaDTO personDTO);
        Task<PersonaDTO> GetPersonDetails(Guid id);

    }
}
