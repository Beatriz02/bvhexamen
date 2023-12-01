using System;
using System.Collections.Generic;

namespace Bvh.Examen.Control.Entitys
{
    public partial class NotificacionEmailDto
    {
        public int Id { get; set; }
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? DoctoBase64 { get; set; }
        public string? Docto2Base64 { get; set; }

        public NotificacionDto EntNotificacion { get; set; }

    }
}
