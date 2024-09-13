using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeLasChaskas
{
    public partial class Frm_Productos : Form
    {
        Categorias Control;
        public Frm_Productos()
        {
            InitializeComponent();
            Control = new Categorias();
        }
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            CrearBotonesCategorias(Control.ObtenerCategorias());
        }
        public void CrearBotonesCategorias(List<Entidad_Categorias> categorias)
        {
            foreach (var categoria in categorias)
            {
                Button boton = new Button();
                boton.Text = categoria.Nombre;
                boton.Tag = categoria.No_Categoria;
                boton.Size = new Size(140, 30);
                PanelBotonesC.Controls.Add(boton);
            }
        }
    }
}
