using Bvh.Examen.Control.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bvh.Examen.Control
{
    internal interface IOperaciones<T>
    {
        Respuesta<T> Guardar(T obj);
        Respuesta<T> ObtenerElemento(int id);
         Respuesta<List<T>> ObtenerElementosPorId(int id);
         Respuesta<List<T>> ObtenerTodosElementos();
         Respuesta<bool> Actualizar(T obj);
         Respuesta<bool> Eliminar(int id);
    }
}
