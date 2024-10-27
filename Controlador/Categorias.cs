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
        public int ObtenerCategoriaN(string Nombre)
        { 
            return enlace.ObtenerCategoriaN(Nombre);
        }
        public void ActualizarCategoria(int ID, string Nombre)
        {
            enlace.ActualizarCategoria(ID,Nombre);
        }
        public void EliminarCategoria(int ID)
        {
            enlace.EliminarCategoria(ID);
        }
        public void GuardarCategoria(string Nombre)
        {
            enlace.GuardarCategoria(Nombre);
        }
        public List<Entidad_Categorias> ObtenerCategorias()
        {
            return enlace.ObtenerCategorias();

        }
    }
}
