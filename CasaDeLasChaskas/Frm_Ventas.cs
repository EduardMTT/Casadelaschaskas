using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeLasChaskas
{
    public partial class Frm_Ventas : Form
    {
        Ventas ControlVentas;
        public Frm_Ventas()
        {
            InitializeComponent();
            ControlVentas = new Ventas();
        }
        public void ReorganizarDATA()
        {
            DtgVentas.Columns["Fecha"].DisplayIndex = 0;
            DtgVentas.Columns["Cliente"].DisplayIndex = 1;
            DtgVentas.Columns["NombreP"].DisplayIndex = 2; // Producto
            DtgVentas.Columns["Tamaño"].DisplayIndex = 3;
            DtgVentas.Columns["Precio"].DisplayIndex = 4;
            DtgVentas.Columns["Cantidad"].DisplayIndex = 5;
            DtgVentas.Columns["Total"].DisplayIndex = 6;
            DtgVentas.Columns["NombreP"].HeaderText = "Producto";
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            DtgVentas.DataSource = ControlVentas.ObtenerVentas();
            DtgVentas.Columns["PRODUCTO"].Visible = false;
            ReorganizarDATA();
        }

        private void DT1_ValueChanged(object sender, EventArgs e)
        {
            string fechaFormateada = DT1.Value.ToString("yyyy-MM-dd");
            MessageBox.Show("Se cambio " + fechaFormateada);
            DtgVentas.DataSource = ControlVentas.ObtenerVentasFiltro(fechaFormateada);
            ReorganizarDATA();
        }
    }
}
