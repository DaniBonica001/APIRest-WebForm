using APIRest_WebForm.DTO;
using APIRest_WebForm.Models;

namespace APIRest_WebForm.Mapper
{
    public static class PersonaMapper
    {

        public static Persona FromPersonaDTOToPersona(PersonaDTO personaDTO)
        {
            return new Persona
            {
                Nombre = personaDTO.Nombre,
                Apellido = personaDTO.Apellido,
                NumeroIdentificacion = personaDTO.NumeroIdentificacion,
                Email = personaDTO.Email,
                TipoIdentificacion = personaDTO.TipoIdentificacion
            };
        }   

        public static PersonaDTO FromPersonaToPersonaDTO(Persona persona)
        {
            return new PersonaDTO
            {
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                NumeroIdentificacion = persona.NumeroIdentificacion,
                Email = persona.Email,
                TipoIdentificacion = persona.TipoIdentificacion
            };
        }
          
    }
}
