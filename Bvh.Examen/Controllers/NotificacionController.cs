using Bvh.Examen.Control.Entitys;
using Bvh.Examen.Control.Modelo;
using Bvh.Examen.Control.OperacionesEf;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bvh.Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionController : ControllerBase
    {
        private CtrlNotificacion _operacion;

        public NotificacionController()
        {
            _operacion = new CtrlNotificacion();
        }
        // GET: api/<NotificacionController>


        // POST api/<NotificacionController>
        [HttpPost]
        public ActionResult<NotificacionDto> Post( NotificacionDto obj)
        {
            if(obj != null)
            {
                Respuesta<NotificacionDto> _respuesta= _operacion.Guardar(obj);
                if (!_respuesta.Exitoso)
                {
                    return UnprocessableEntity();
                }
                return _respuesta.Elemento;
            }
            return Problem("Los datos son necesarios para procesar la información");
        }
    }
}
