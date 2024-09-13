using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidad_Categorias
    {
        private int _No_Categoria;
        private string _Nombre;
        public int No_Categoria { get => _No_Categoria; set => _No_Categoria = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
