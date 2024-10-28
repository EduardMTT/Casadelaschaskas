using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Mysqlx.Cursor;

namespace Conexion
{
    public class EnlaceVentas
    {
        Enlace Conectar;
        public EnlaceVentas() 
        {
            Conectar = new Enlace("localhost", "root", "Casa_de_las_Chaskas", 3306);
        }
        public static int ObtenerUltimoIdInsertado()
        {
            int ultimoId = 0;
            string connectionString = "server=localhost;user=root;database=casa_de_las_chaskas;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string consulta = "SELECT MAX(ID) AS UltimaClavePrimaria FROM venta;";
                using (MySqlCommand command = new MySqlCommand(consulta, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("UltimaClavePrimaria")))
                            {
                                ultimoId = reader.GetInt32("UltimaClavePrimaria");
                            }
                        }
                    }
                }
            }
            return ultimoId;
        }
        public List<Entidad_Ventas> ObtenerVentasFiltro(string Fecha)
        {
            var Lista = new List<Entidad_Ventas>();
            var Tabla = new DataTable();
            Tabla = Conectar.ObtenerDatos(string.Format("SELECT * FROM registro_ventas WHERE Fecha='{0}';",Fecha));

            foreach (DataRow renglon in Tabla.Rows)
            {
                var venta = new Entidad_Ventas()
                {
                    Fecha = renglon[1].ToString(),
                    Cliente = renglon[2].ToString(),
                    NombreP = renglon[3].ToString(),
                    Precio = double.Parse(renglon[4].ToString()),
                    Tamaño = renglon[5].ToString(),
                    Cantidad = int.Parse(renglon[6].ToString()),
                    Total = double.Parse(renglon[7].ToString())
                };
                Lista.Add(venta);
            }
            return Lista;
        }
        public List<Entidad_Ventas> ObtenerVentas()
        {
            var Lista = new List<Entidad_Ventas>();
            var Tabla = new DataTable();
            Tabla = Conectar.ObtenerDatos("SELECT * FROM registro_ventas");

            foreach (DataRow renglon in Tabla.Rows)
            {
                var venta = new Entidad_Ventas()
                {
                    Fecha = renglon[1].ToString(),
                    Cliente = renglon[2].ToString(),
                    NombreP = renglon[3].ToString(),
                    Precio = double.Parse(renglon[4].ToString()),
                    Tamaño = renglon[5].ToString(),
                    Cantidad = int.Parse(renglon[6].ToString()),
                    Total = double.Parse(renglon[7].ToString())
                };
                Lista.Add(venta);
            }
            return Lista;
        }
        public void GuardarVENTA(int Producto,string NombreProducto,int Cantidad,double Total,string fecha, string Cliente, string Tamaño,double Precio)
        {
            int ID = ObtenerUltimoIdInsertado();
            string Consulta = string.Format("INSERT INTO detalles_ventas VALUES({0},{1},'{2}',{3},{4})",ID,Producto,NombreProducto,Cantidad,Total);
            Conectar.EjecutarConsulta(Consulta);
            Consulta = string.Format("INSERT INTO registro_ventas VALUES(NULL,'{0}','{1}','{2}',{3},'{4}',{5},{6})",fecha,Cliente,NombreProducto,Precio,Tamaño,Cantidad,Total);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void GuardarPreventa(Entidad_Ventas venta)
        {
            string Consulta=string.Format("INSERT INTO Venta VALUES(NULL,'{0}','{1}');",venta.Fecha,venta.Cliente);
            Conectar.EjecutarConsulta(Consulta);
        }
        public double VentasTotales(string Fecha)
        {
            string Consulta = string.Format("SELECT SUM(Total) FROM registro_ventas WHERE Fecha='{0}';",Fecha);
            return Conectar.EjecutarConsultaSuma(Consulta);
           
        }
        public void EliminarCategoria(int ID)
        {
            string Consulta = string.Format("DELETE FROM Productos WHERE FKNo_Categoria = {0};", ID);
            Conectar.EjecutarConsulta(Consulta);
            Consulta = string.Format("DELETE FROM Categoria WHERE No_Categoria={0};", ID);
            Conectar.EjecutarConsulta(Consulta);
        }
    }
}
