using System;
using System.Collections.Generic;

namespace APIRest_WebForm.Models
{
    public partial class Usuario
    {
        public Guid Identificador { get; set; }
        public string? Usuario1 { get; set; }
        public string? Pass { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
