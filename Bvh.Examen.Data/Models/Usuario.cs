using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public int IdRegion { get; set; }
        public string Nombre { get; set; } = null!;
        public string APaterno { get; set; } = null!;
        public string AMaterno { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public long? Celular { get; set; }
        public string Correo { get; set; } = null!;

        public virtual Region IdRegionNavigation { get; set; } = null!;
    }
}
