using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class NotificacionApi
    {
        public int Id { get; set; }
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string UrlApi { get; set; } = null!;
        public string? CampoLibre { get; set; }

        public virtual Notificacion IdNotificacionNavigation { get; set; } = null!;
    }
}
