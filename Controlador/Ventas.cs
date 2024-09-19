using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Ventas
    {
        EnlaceVentas enlace;
        public Ventas() 
        {
            enlace = new EnlaceVentas();
        }
        public void GuardarVenta(Entidad_Ventas venta)
        {
            enlace.GuardarVenta(venta);
        }
        public List<Entidad_Ventas> ObtenerVentasFiltro(string Fecha)
        {
            return enlace.ObtenerVentasFiltro(Fecha);
        }
        public List<Entidad_Ventas> ObtenerVentas()
        {
            return enlace.ObtenerVentas();
        }
    }
}
