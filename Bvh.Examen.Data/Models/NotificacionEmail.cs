using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class NotificacionEmail
    {
        public int Id { get; set; }
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? DoctoBase64 { get; set; }
        public string? Docto2Base64 { get; set; }

        public virtual Notificacion IdNotificacionNavigation { get; set; } = null!;
    }
}
