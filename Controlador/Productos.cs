using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<Entidad_Productos> ObtenerProducto(int ID)
        {
            return enlace.ObtenerProducto(ID);
        }
        public void AgregarProducto(Entidad_Productos entidad)
        {
            enlace.GuardarProducto(entidad);
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
