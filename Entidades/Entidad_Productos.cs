using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidad_Productos
    {
        private int _No_Producto;
        private string _Producto;
        private string _Tamaño;
        private decimal _Precio;
        private int _FKNo_Categoria;
        private string _Imagen;
        private string _Estatus;
        private string _Categoria;
        public int No_Producto { get => _No_Producto; set => _No_Producto = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Tamaño { get => _Tamaño; set => _Tamaño = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public int FKNo_Categoria { get => _FKNo_Categoria; set => _FKNo_Categoria = value; }
        public string Imagen { get => _Imagen; set => _Imagen = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
    }
}
