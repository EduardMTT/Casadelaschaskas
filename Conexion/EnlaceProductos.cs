using Entidades;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
            Conectar = new Enlace("localhost","root", "Casa_de_las_Chaskas_1", 3306);
        }
        public List<Entidad_Productos> ObtenerProductos(int No_Categoria)
        {

            var Lista = new List<Entidad_Productos>();
            var Tabla = new DataTable();
                Tabla = Conectar.ObtenerDatos(string.Format("SELECT No_Producto,Producto,Tamaño,Precio,Imagen,Estatus,FKNo_Categoria FROM categoria c " +
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
                        Estatus = renglon[5].ToString(),
                        Categoria = renglon[6].ToString(),
                    };
                    Lista.Add(producto);
                }
                return Lista;
        }
        public void ActualizarProducto(Entidad_Productos productos)
        {
            string Consulta = string.Format("UPDATE Productos SET Producto ='{0}',Tamaño='{1}',Precio={2}," +
                "Imagen='{3}', Estatus'{4}' FKNo_Categoria={5} WHERE No_Producto= {6};",productos.Producto,productos.Tamaño,productos.Precio,
                productos.Imagen,productos.Estatus,productos.Categoria,productos.No_Producto);
            Conectar.EjecutarConsulta(Consulta);
        }
        public List<Entidad_Productos> ObtenerProducto(int ID)
        {
            var Lista = new List<Entidad_Productos>();
            var Tabla = new DataTable();
            string Consulta = string.Format("SELECT * FROM Productos WHERE No_Producto={0};",ID);
            Tabla = Conectar.ObtenerDatos(Consulta);
            foreach (DataRow Fila in Tabla.Rows)
            {
                var producto = new Entidad_Productos()
                {
                    No_Producto = int.Parse(Fila["No_Producto"].ToString()),
                    Producto = Fila["Producto"].ToString(),
                    Tamaño = Fila[2].ToString(),
                    Precio = decimal.Parse(Fila["Precio"].ToString()),
                    Imagen = Fila["Imagen"].ToString(),
                    Estatus = Fila["Estatus"].ToString(),
                    FKNo_Categoria = int.Parse(Fila["FKNo_Categoria"].ToString())
                };
                Lista.Add(producto);
            }
            return Lista;
        }
        public void GuardarProducto(string P,string T,decimal Pre,string I,string Es, int C)
        {

            string Comando = string.Format("INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, Estatus, FKNo_Categoria) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', {5});",
                P, T, Pre, I, Es, C);

            Conectar.EjecutarConsulta(Comando);
            Console.WriteLine(Comando);
        }

        public void EliminarProducto(int ID)
        {
            string Comando = string.Format("SET FOREIGN_KEY_CHECKS = 0; DELETE FROM Productos WHERE No_Producto = {0}; SET FOREIGN_KEY_CHECKS = 1;", ID);
            Conectar.EjecutarConsulta(Comando);

        }
    }
}