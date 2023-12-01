using System;
using System.Collections.Generic;

namespace Bvh.Examen.Control.Entitys
{
    public partial class NotificacionDto
    {
       

        public int Id { get; set; }
        public int IdTipoNotificacion { get; set; }
        public DateTime DteFechaCreacion { get; set; }
        public int IdEmpleado { get; set; }
        public int IdRegion { get; set; }
        public string Titulo { get; set; } = null!;

    }
}
