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
        private int _PRODUCTO;

        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Total { get => _Total; set => _Total = value; }
        public int PRODUCTO { get => _PRODUCTO; set => _PRODUCTO = value; }
    }
}
