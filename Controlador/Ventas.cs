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
        public void GuardarVenta(int Producto,string NombreProducto,int Cantidad,double Precio,string fecha, string Cliente, string Tamaño)
        {
            double Total = Cantidad * Precio;
            enlace.GuardarVENTA(Producto,NombreProducto,Cantidad,Total,fecha, Cliente,Tamaño,Precio);
        }
        public void GuardarPreVenta(Entidad_Ventas venta)
        {
            enlace.GuardarPreventa(venta);
        }
        public double VentasTotales(string Fecha)
        {
           return enlace.VentasTotales(Fecha);
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
