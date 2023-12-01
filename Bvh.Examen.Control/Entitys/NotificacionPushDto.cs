using System;
using System.Collections.Generic;

namespace Bvh.Examen.Control.Entitys
{
    public partial class NotificacionPushDto
    {
        public int Id { get; set; }
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; } = null!;

        public NotificacionDto EntNotificacion { get; set; }

    }
}
