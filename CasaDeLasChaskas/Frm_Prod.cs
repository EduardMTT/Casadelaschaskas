using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CasaDeLasChaskas
{
    public partial class Frm_Prod : Form
    {
        Categorias ControlCategorias;
        Productos ControlProductos;
        public Frm_Prod()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            ControlProductos = new Productos();
        }

        private void Frm_Prod_Load(object sender, EventArgs e)
        {
            CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());
        }
        public void CrearBotonesCategorias(List<Entidad_Categorias> categorias)
        {
            PanelBotonesC.Controls.Clear();
            foreach (var categoria in categorias)
            {
                Button boton = new Button();
                ContextMenuStrip Opciones = new ContextMenuStrip();
                ToolStripMenuItem opcionEliminar = new ToolStripMenuItem("Eliminar");
                ToolStripMenuItem opcionActualizar = new ToolStripMenuItem("Actualizar");
                opcionEliminar.Click += (sender, e) => OpcionEliminar_Click(sender, e, categoria.No_Categoria, categoria.Nombre);
                opcionActualizar.Click += (sender, e) => OpcionActualizar_Click(sender, e, categoria.No_Categoria, categoria.Nombre);
                Opciones.Items.Add(opcionEliminar);
                Opciones.Items.Add(opcionActualizar);
                boton.Text = categoria.Nombre;
                boton.Font = new Font("Yu Gothic", 13);
                boton.Tag = categoria.No_Categoria;
                boton.Size = new Size(140, 30);
                boton.Click += (sender, e) => BuscarProductos(sender, e, categoria.No_Categoria, categoria.Nombre);
                boton.ContextMenuStrip = Opciones;
                PanelBotonesC.Controls.Add(boton);
            }
        }
        private void BuscarProductos(object sender, EventArgs e, int Categoria, string Nombre)
        {
            try
            {
                CrearBotonesProductos(ControlProductos.ObtenerProductos(Categoria));

            }
            catch
            {
                TablePanel.Controls.Clear();
                MessageBox.Show("Esta categoria no tiene ningun producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CrearBotonesProductos(List<Entidad_Productos> productos)
        {
            TablePanel.Controls.Clear();
            foreach (var producto in productos)
            {
                Button boton = new Button();
                ContextMenuStrip Opciones = new ContextMenuStrip();
                ToolStripMenuItem opcionEliminar = new ToolStripMenuItem("Eliminar");
                opcionEliminar.Click += (sender, e) => OpcionEliminar_ClickProdu(sender, e, producto.No_Producto, producto.Producto);
                Opciones.Items.Add(opcionEliminar);
                string ruta = producto.Imagen;
                boton.BackgroundImage = System.Drawing.Image.FromFile(ruta);
                boton.BackgroundImageLayout = ImageLayout.Stretch;
                boton.BackColor = Color.White;
                boton.Font = new Font(boton.Font.FontFamily,9);
                boton.Tag = producto.No_Producto;
                boton.Size = new Size(140, 140);
                boton.ContextMenuStrip = Opciones;
                TablePanel.Controls.Add(boton);
            }
        }
        public void OpcionEliminar_ClickProdu(object sender, EventArgs e, int IDProducto, string Nombre)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar este producto: " + Nombre + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlProductos.EliminarProducto(IDProducto);
                MessageBox.Show("Producto Eliminado!", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se cancelo la operacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void OpcionActualizar_Click(object sender, EventArgs e, int Categoria, string Nombre)
        {
            Frm_ActualizarCategoria abrir = new Frm_ActualizarCategoria(Categoria, Nombre);
            abrir.Show();
            this.Close();
        }
        public void OpcionEliminar_Click(object sender, EventArgs e, int Categoria, string Nombre)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar la categoria: " + Nombre + "?\n" +
                "Al realizar esta operacion se eliminaran tambien los productos que conformen esta categoria.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlCategorias.EliminarCategoria(Categoria);
                MessageBox.Show("Categoria Eliminada!", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());

            }
            else
            {
                MessageBox.Show("Se cancelo la operacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarProductos frmAgregarProductos = new FrmAgregarProductos();
            frmAgregarProductos.Show();
        }
    }
}
