using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Categorias
    {
        EnlaceCategorias enlace;
        public Categorias() 
        {
            enlace = new EnlaceCategorias();
        }
        public List<Entidad_Categorias> ObtenerCategorias()
        {
            return enlace.ObtenerCategorias();

        }
    }
}
