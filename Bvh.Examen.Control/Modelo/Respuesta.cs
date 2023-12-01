using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bvh.Examen.Control.Modelo
{
    public enum EnumError
    {
        SIN_DATOS = 1,
        ERROR_SERVIDOR = 500,
        NO_ENCONTRADO = 404,
        ENCONTRADO = 200,
        CREADO = 201

    }

    public class Respuesta<T>
    {
        public bool Exitoso { get; set; }
        public T Elemento { get; set; }
        public List<T> ListaElementos { get; set; }
        public EnumError idCodigoError { get; set; }
    }
}
