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
using System.IO;

namespace CasaDeLasChaskas
{
    public partial class Frm_Productos : Form
    {
        Categorias ControlCategorias;
        Productos ControlProductos;
        public Frm_Productos()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            ControlProductos = new Productos();
        }
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());
        }
        private void BuscarProductos(object sender,EventArgs e, int Categoria)
        {
            Grid.DataSource=ControlProductos.ObtenerProductos(Categoria);
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Visible = false;
            Grid.Columns[2].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[4].Visible = false;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid.Columns[5].Width = 200;
            Grid.Columns[6].Visible = false;
            CrearBotonesProductos(ControlProductos.ObtenerProductos(Categoria));
        }
        public void CrearBotonesProductos(List<Entidad_Productos>productos)
        {
            TablePanel.Controls.Clear();
            foreach (var producto in productos)
            {
                Button boton = new Button();
                boton.Text = producto.Producto;
                boton.Tag = producto.No_Producto;
                boton.Size = new Size(140, 40);
                TablePanel.Controls.Add(boton);
            }
        }
        public void CrearBotonesCategorias(List<Entidad_Categorias> categorias)
        {
            foreach (var categoria in categorias)
            {
                Button boton = new Button();
                boton.Text = categoria.Nombre;
                boton.Tag = categoria.No_Categoria;
                boton.Size = new Size(140, 30);
                boton.Click += (sender, e) => BuscarProductos(sender,e,categoria.No_Categoria);
                PanelBotonesC.Controls.Add(boton);
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_NuevaCategoria abrir = new Frm_NuevaCategoria();
            abrir.ShowDialog();
        }
    }
}
