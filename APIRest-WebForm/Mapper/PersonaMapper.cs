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

            var nombre = persona.Nombre;
            var apellido = persona.Apellido;
            var numeroIdentificacion = persona.NumeroIdentificacion;
            var email = persona.Email;
            var tipoIdentificacion = persona.TipoIdentificacion;

            return new PersonaDTO(nombre,apellido,numeroIdentificacion,email,tipoIdentificacion,"","" );
        }
          
    }
}
