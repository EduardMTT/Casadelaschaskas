using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class EnlaceProductos
    {
        Enlace Conectar;
        public EnlaceProductos()
        {
            Conectar = new Enlace("localhost","root","casa_de_las_chaskas",3306);
        }
        public List<Entidad_Productos> ObtenerProductos(int No_Categoria)
        {
            var Lista = new List<Entidad_Productos>();
            var Tabla = new DataTable();
            Tabla = Conectar.ObtenerDatos(string.Format("SELECT No_Producto,Producto,Tamaño,Precio,Imagen,FKNo_Categoria FROM categoria c " +
                "LEFT JOIN productos p ON c.No_Categoria = p.FKNo_Categoria WHERE c.No_Categoria={0};", No_Categoria));

            foreach (DataRow renglon in Tabla.Rows)
            {
                var producto = new Entidad_Productos()
                {
                    No_Producto = Convert.ToInt32(renglon[0]),
                    Producto = renglon[1].ToString(),
                    Tamaño = renglon[2].ToString(),
                    Precio = Convert.ToDecimal(renglon[3]),
                    Imagen = renglon[4].ToString(),
                    Categoria = renglon[5].ToString(),
                };
                Lista.Add(producto);
            }
            return Lista;
        }

        public void GuardarProducto(Entidad_Productos Producto)
        {
            string Comando =string.Format("INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, FKNo_Categoria) VALUES" +
                "('{0}','{1}',{2},{3},{4})",Producto.Producto,Producto.Tamaño, Producto.Precio,Producto.Imagen,Producto.Categoria);
            Conectar.EjecutarConsulta(Comando);
        }
        public void EliminarProducto(int ID)
        {
            string Comando = string.Format("Delete from Productos where No_Producto = {0}", ID);
            Conectar.EjecutarConsulta(Comando);
        }
    }
}

