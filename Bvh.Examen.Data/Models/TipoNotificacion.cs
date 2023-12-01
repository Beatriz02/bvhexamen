using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class TipoNotificacion
    {
        public TipoNotificacion()
        {
            Notificacions = new HashSet<Notificacion>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Notificacion> Notificacions { get; set; }
    }
}
