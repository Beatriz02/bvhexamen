using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class NotificacionSm
    {
        public int Id { get; set; }
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual Notificacion IdNotificacionNavigation { get; set; } = null!;
    }
}
