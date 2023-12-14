using APIRest_WebForm.Data;
using APIRest_WebForm.DTO;
using APIRest_WebForm.Mapper;
using APIRest_WebForm.Models;
using APIRest_WebForm.Services.Utils;

namespace APIRest_WebForm.Services.PersonaServices
{
    public class PersonServiceImpl : IPersonService
    {

        private readonly webUsersContext dbContext;

        public PersonServiceImpl(webUsersContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<string> Register(PersonaDTO personDTO)
        {
            var personExists = await dbContext.Personas.FindAsync(personDTO.NumeroIdentificacion);
            if (personExists != null)
            {
                Persona newPerson = PersonaMapper.FromPersonaDTOToPersona(personDTO);
                newPerson.Identificador = Guid.NewGuid();
                newPerson.FechaCreacion = DateTime.Now;

                var passwordEncrypt = PasswordHasher.ComputeHash(personDTO.Pass,100);

                Usuario newUsername = new()
                {
                    Identificador = newPerson.Identificador,
                    Usuario1 = personDTO.Usuario1,
                    Pass = passwordEncrypt,
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
