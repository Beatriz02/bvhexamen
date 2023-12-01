using System;
using System.Collections.Generic;

namespace Bvh.Examen.Control.Entitys
{
    public partial class NotificacionApiDto
    {
        public int Id { get; set; }
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string UrlApi { get; set; } = null!;
        public string? CampoLibre { get; set; }

        public NotificacionDto EntNotificacion { get; set; }

    }
}
