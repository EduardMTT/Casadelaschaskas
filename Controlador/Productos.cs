using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Productos
    {
        EnlaceProductos enlace;
        public Productos()
        { 
            enlace= new EnlaceProductos();
        }
        public void EliminarProducto(int ID)
        {
            enlace.EliminarProducto(ID);
        }
        public List<Entidad_Productos> ObtenerProductos(int No_Categoria)
        {
            return enlace.ObtenerProductos(No_Categoria);
        }
    }
}
