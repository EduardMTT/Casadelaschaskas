using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    public class EnlaceVentas
    {
        Enlace Conectar;
        public EnlaceVentas() 
        {
            Conectar = new Enlace("localhost", "root", "casa_de_las_chaskas", 3306);
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
        public void GuardarVenta(Entidad_Ventas venta)
        {
            string Consulta;
            if (venta.Fecha != string.Empty)
            {
                Consulta = string.Format("INSERT INTO Venta VALUES(NULL,'{0}','{1}')", venta.Fecha, venta.Cliente);
                Conectar.EjecutarConsulta(Consulta);
            }
            int ID = ObtenerUltimoIdInsertado();
            Consulta = string.Format("INSERT INTO detalles_ventas VALUES({0},{1},{2},{3})",ID,venta.PRODUCTO,venta.Cantidad,venta.Total);
            Conectar.EjecutarConsulta(Consulta);
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
