using APIRest_WebForm.Data;
using APIRest_WebForm.DTO;
using APIRest_WebForm.Mapper;
using APIRest_WebForm.Models;

namespace APIRest_WebForm.Services
{
    public class PersonServiceImpl : IPersonService
    {

        private readonly webUsersContext dbContext;

        public PersonServiceImpl(webUsersContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<String> Register(PersonaDTO personDTO)
        {
            var personExists = await dbContext.Personas.FindAsync(personDTO.NumeroIdentificacion);
            if (personExists != null)
            {
                Persona newPerson = PersonaMapper.FromPersonaDTOToPersona(personDTO);
                newPerson.Identificador = Guid.NewGuid();
                newPerson.FechaCreacion = DateTime.Now;


                Usuario newUsername = new()
                {
                    Identificador = newPerson.Identificador,
                    Usuario1 = personDTO.Usuario1,
                    Pass = personDTO.Pass
                };

                dbContext.Personas.Add(newPerson);
                dbContext.Usuarios.Add(newUsername);
                await dbContext.SaveChangesAsync();

                return "CREATED";

            }
            else
            {
                return "USUARIO EXISTENTE"; 
            }
        }

        public async Task<PersonaDTO?> GetPersonDetails(Guid id)
        {
            Persona person = await dbContext.Personas.FindAsync(id);

            if (person != null)
            {
                return PersonaMapper.FromPersonaToPersonaDTO(person);
            }
            else
            {
                return null;
            }
        }

        
    }
}
