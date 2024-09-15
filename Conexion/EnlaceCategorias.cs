using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
            Conectar = new Enlace("localhost", "root", "casa_de_las_chaskas", 3306);
        }
        public void GuardarCategoria(string Nombre)
        {
            string Consulta = string.Format("INSERT INTO Categoria VALUES(NULL,'{0}')",Nombre);
            Conectar.EjecutarConsulta(Consulta);
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
