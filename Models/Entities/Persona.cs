using System;
using System.Collections.Generic;

namespace personapi_dotnet.Models.Entities
{
    public partial class Persona
    {
        public Persona()
        {
            Estudios = new HashSet<Estudio>();
            Telefonos = new HashSet<Telefono>();
        }

        public int Cc { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Genero { get; set; }
        public byte? Edad { get; set; }

        public virtual ICollection<Estudio> Estudios { get; set; }
        public virtual ICollection<Telefono> Telefonos { get; set; }
    }
}
