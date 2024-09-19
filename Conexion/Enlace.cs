using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Enlace
    {
        public MySqlConnection Conectar;
        public Enlace(string Servidor, string Usuario, string BD, uint Puerto)
        {
            MySqlConnectionStringBuilder CadenaConexion = new MySqlConnectionStringBuilder();
            CadenaConexion.Server = Servidor;
            CadenaConexion.UserID = Usuario;
            CadenaConexion.Database = BD;
            CadenaConexion.Port = Puerto;
            Conectar = new MySqlConnection(CadenaConexion.ToString());
        }
        public DataTable ObtenerDatos(string Consulta)
        {
            DataTable Tabla = new DataTable();
            try
            {
                Conectar.Open();
                using (MySqlCommand Comando = new MySqlCommand(Consulta, Conectar))
                {
                    using (MySqlDataAdapter Adaptador = new MySqlDataAdapter(Comando))
                    {
                        Adaptador.Fill(Tabla);
                        Console.WriteLine("Consulta Ejecutada Correctamente");
                    }
                }
                Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: ", ex.Message);
            }
            return Tabla;
        }
        public double EjecutarConsultaSuma(string Consulta)
        {
            double resultado = 0;
            try
            {
                Conectar.Open();
                using (MySqlCommand Comando = new MySqlCommand(Consulta, Conectar))
                {
                    object valor = Comando.ExecuteScalar();
                    if (valor != null && double.TryParse(valor.ToString(), out double valorDouble))
                    {
                        resultado = valorDouble;
                    }
                }
                Conectar.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }

            return resultado;
        }
        public void EjecutarConsulta(string Consulta)
        {
            try
            {
                Conectar.Open();
                using (MySqlCommand Comando = new MySqlCommand(Consulta, Conectar))
                {
                    Comando.ExecuteNonQuery();
                    Console.WriteLine("Consulta Ejecutada correctamente");

                }
                Conectar.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: ", ex.Message);
            }
        }
    }
}
