using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entidad_Ventas
    {
        private string _Fecha;
        private string _Cliente;
        private int _Cantidad;
        private double _Total;
        private double _Precio;
        private int _PRODUCTO;
        private string nombreP;
        private string _Tamaño;

        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Total { get => _Total; set => _Total = value; }
        public int PRODUCTO { get => _PRODUCTO; set => _PRODUCTO = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public string Tamaño { get => _Tamaño; set => _Tamaño = value; }
        public string NombreP { get => nombreP; set => nombreP = value; }
    }
}
