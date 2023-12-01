using System;
using System.Collections.Generic;

namespace Bvh.Examen.Control.Entitys
{
    public partial class UsuarioDto
    {
        public int Id { get; set; }
        public int IdRegion { get; set; }
        public string Nombre { get; set; } = null!;
        public string APaterno { get; set; } = null!;
        public string AMaterno { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; } = null!;

    }
}
