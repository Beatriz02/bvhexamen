using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class Notificacion
    {
        public Notificacion()
        {
            NotificacionApis = new HashSet<NotificacionApi>();
            NotificacionEmails = new HashSet<NotificacionEmail>();
            NotificacionPushes = new HashSet<NotificacionPush>();
            NotificacionSms = new HashSet<NotificacionSm>();
        }

        public int Id { get; set; }
        public int IdTipoNotificacion { get; set; }
        public DateTime DteFechaCreacion { get; set; }
        public int IdEmpleado { get; set; }
        public int IdRegion { get; set; }
        public string Titulo { get; set; } = null!;

        public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
        public virtual Region IdRegionNavigation { get; set; } = null!;
        public virtual TipoNotificacion IdTipoNotificacionNavigation { get; set; } = null!;
        public virtual ICollection<NotificacionApi> NotificacionApis { get; set; }
        public virtual ICollection<NotificacionEmail> NotificacionEmails { get; set; }
        public virtual ICollection<NotificacionPush> NotificacionPushes { get; set; }
        public virtual ICollection<NotificacionSm> NotificacionSms { get; set; }
    }
}
