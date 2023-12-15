using System;
using System.Collections.Generic;

namespace APIRest_WebForm.Models
{
    public partial class Persona
    {
        public Guid Identificador { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroIdentificacion { get; set; }
        public string? Email { get; set; }
        public string? TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? TipoNumeroIdentificacion { get; set; }
        public string? NombreApellidos { get; set; }
    }
}
