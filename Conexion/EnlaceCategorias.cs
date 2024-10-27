using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class EnlaceCategorias
    {
        Enlace Conectar;
        public EnlaceCategorias()
        {
            Conectar = new Enlace("localhost", "root", "Casa_de_las_Chaskas", 3306);
        }
        public void GuardarCategoria(string Nombre)
        {
            string Consulta = string.Format("INSERT INTO Categoria VALUES(NULL,'{0}')",Nombre);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void EliminarCategoria(int ID)
        {
            string Consulta = string.Format("DELETE FROM Productos WHERE FKNo_Categoria = {0};", ID);
            Conectar.EjecutarConsulta(Consulta);
            Consulta = string.Format("DELETE FROM Categoria WHERE No_Categoria={0};", ID);
            Conectar.EjecutarConsulta(Consulta);
        }
        public void ActualizarCategoria(int ID,string Nombre)
        {
            string Consulta = string.Format("UPDATE Categoria SET Nombre ='{0}' WHERE No_Categoria={1}",Nombre,ID);
            Conectar.EjecutarConsulta(Consulta);
        }
        public int ObtenerCategoriaN(string Nombre)
        {
            string Consulta =string.Format( "SELECT No_Categoria AS D FROM Categoria WHERE Nombre='{0}'",Nombre);
            int ID = 0;
            string connectionString = "server=localhost;user=root;database=casa_de_las_chaskas;port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(Consulta, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("D")))
                            {
                                ID = reader.GetInt32("D");
                            }
                        }
                    }
                }
            }
            if (ID != 0)
            {
                return ID;
            }
            else
            {
                return 0;
            }
        }
        public List<Entidad_Categorias> ObtenerCategorias()
        {
            var Lista = new List<Entidad_Categorias>();
            var Tabla = new DataTable();
            string Consulta = "SELECT * FROM Categoria";
            Tabla = Conectar.ObtenerDatos(Consulta);
            foreach (DataRow fila in Tabla.Rows)
            {
                var Categoria = new Entidad_Categorias()
                {
                    No_Categoria = int.Parse(fila[0].ToString()),
                    Nombre = fila[1].ToString()
                };
                Lista.Add(Categoria);
            }
            return Lista;
        }
    }
}
