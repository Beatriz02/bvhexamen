using Bvh.Examen.Control.Entitys;
using Bvh.Examen.Control.Modelo;
using Bvh.Examen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bvh.Examen.Control.OperacionesEf
{
    public class CtrlNotificacion : IOperaciones<NotificacionDto>
    {
        private readonly BvhExamenContext _context;
        public CtrlNotificacion(BvhExamenContext context)
        {
            this._context = context;
        }
        public CtrlNotificacion()
        {
            this._context = new BvhExamenContext();
        }

        public Respuesta<bool> Actualizar(NotificacionDto obj)
        {
            throw new NotImplementedException();
        }

        public Respuesta<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<NotificacionDto>  Guardar(NotificacionDto obj)
        {
            if (_context.Notificacions == null)
            {
                return new Respuesta<NotificacionDto>() { Exitoso = false, idCodigoError = EnumError.NO_ENCONTRADO };
            }
            Notificacion _entidad= new Notificacion()
            {
                DteFechaCreacion= obj.DteFechaCreacion,
                IdEmpleado= obj.IdEmpleado,
                IdRegion= obj.IdRegion,
                IdTipoNotificacion = obj.IdTipoNotificacion,
                Titulo= obj.Titulo
            };
            _context.Notificacions.Add(_entidad);
            
            try
            {
                _context.SaveChanges();
                obj.Id = _entidad.Id;
                return new Respuesta<NotificacionDto>() { Exitoso = true, idCodigoError = EnumError.CREADO, Elemento = obj };

            }
            catch (Exception)
            {

                return new Respuesta<NotificacionDto>() { Exitoso = false, idCodigoError = EnumError.ERROR_SERVIDOR };
            }
        }

        public Respuesta<NotificacionDto> ObtenerElemento(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<List<NotificacionDto>> ObtenerElementosPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<List<NotificacionDto>> ObtenerTodosElementos()
        {
            throw new NotImplementedException();
        }

  
    }
}
