using System;
using System.Collections.Generic;

namespace Bvh.Examen.Data.Models
{
    public partial class Region
    {
        public Region()
        {
            Notificacions = new HashSet<Notificacion>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Notificacion> Notificacions { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
