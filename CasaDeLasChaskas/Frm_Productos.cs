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
using System.Collections;

namespace CasaDeLasChaskas
{
    public partial class Frm_Productos : Form
    {
        Categorias ControlCategorias;
        Productos ControlProductos;
        Entidad_Productos _Productos;
        public Frm_Productos()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            ControlProductos = new Productos();
            _Productos = new Entidad_Productos();
        }
        public void CargarDatos()
        {
            _Productos.No_Producto = 0;
            _Productos.Producto = TxtProducto.Text.ToString();
            _Productos.Precio = decimal.Parse(TxtCosto.Text.ToString());
            _Productos.Tamaño = TxtTamaño.Text.ToString();
            _Productos.Imagen = TxtRuta.Text.ToString().Replace(" ", "_");
            _Productos.FKNo_Categoria = int.Parse(LblID.Text.ToString());
        }
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());
        }
        public void VaciarCajas()
        {
            TxtNo_Producto.Text= string.Empty;
            TxtProducto.Text= string.Empty;
            TxtCosto.Text= string.Empty;
            TxtTamaño.Text= string.Empty;
        }
        public void HabilitarElementos(bool A,bool B, bool C,bool D, bool E, bool F)
        {
            TxtProducto.Enabled = A;
            TxtTamaño.Enabled = B;
            TxtCosto.Enabled = C;
            BtnCargar.Enabled = D;
            BtnGuardar.Enabled = E;
            BtnActualizar.Enabled = F;
        }
        //Creacion de botones y funcionamiento por cada elemento en PRODUCTOS
        #region
        public void OpcionEliminar_ClickProdu(object sender, EventArgs e, int IDProducto, string Nombre,int Categoria)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar este producto: " + Nombre + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlProductos.EliminarProducto(IDProducto);
                MessageBox.Show("Producto Eliminado!", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CrearBotonesProductos(ControlProductos.ObtenerProductos(Categoria));
            }
            else
            {
                MessageBox.Show("Se cancelo la operacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void OpcionActualizar_ClickProdu(object sender, EventArgs e, int Categoria, string Nombre)
        {

        }
        private void BuscarProductos(object sender, EventArgs e, int Categoria,string Nombre)
        {
            try
            {
                LblID.Text = Categoria.ToString();
                LblCategoria.Text = Nombre.ToString();
                /*for (int i = 0; i < Grid.Columns.Count; i++)
                {
                    if (i != 5)
                    {
                        Grid.Columns[i].Visible = false;
                    }
                }
                Grid.Columns[5].Visible = true;
                Grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Grid.Columns[5].Width = 200;*/
                CrearBotonesProductos(ControlProductos.ObtenerProductos(Categoria));

            }
            catch
            {
                TablePanel.Controls.Clear();
                MessageBox.Show("Esta categoria no tiene ningun producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProducto(object sender, EventArgs e, int No_Producto)
        {
            HabilitarElementos(true,true,true,true,false,true);
            List<Entidad_Productos> Lista = ControlProductos.ObtenerProducto(No_Producto);
            var Producto = Lista[0];
            TxtNo_Producto.Text = Producto.No_Producto.ToString();
            TxtProducto.Text=Producto.Producto.ToString();
            TxtCosto.Text = Producto.Precio.ToString();
            TxtTamaño.Text = Producto.Tamaño.ToString();
        }
        public void CrearBotonesProductos(List<Entidad_Productos>productos)
        {
            TablePanel.Controls.Clear();
            foreach (var producto in productos)
            {
                Button boton = new Button();
                ContextMenuStrip Opciones = new ContextMenuStrip();
                ToolStripMenuItem opcionEliminar = new ToolStripMenuItem("Eliminar");
                ToolStripMenuItem opcionActualizar = new ToolStripMenuItem("Actualizar");
                opcionEliminar.Click += (sender, e) => OpcionEliminar_ClickProdu(sender, e,producto.No_Producto,producto.Producto,int.Parse(LblID.Text));
                opcionActualizar.Click += (sender, e) => OpcionActualizar_ClickProdu(sender, e, producto.No_Producto,producto.Producto);
                Opciones.Items.Add(opcionEliminar);
                Opciones.Items.Add(opcionActualizar);
                boton.Text = producto.Producto;
                boton.Tag = producto.No_Producto;
                boton.Size = new Size(140, 40);
                boton.Click += (sender, e) => ObtenerProducto(sender,e,producto.No_Producto);
                boton.ContextMenuStrip = Opciones;
                TablePanel.Controls.Add(boton);
            }
        }
        #endregion
        //Creacion de botones y su funcionamiento para cada elemento en CATEGORIAS
        #region
        public void OpcionEliminar_Click(object sender, EventArgs e, int Categoria,string Nombre)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar la categoria: " +Nombre+ "?\n" +
                "Al realizar esta operacion se eliminaran tambien los productos que conformen esta categoria.", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlCategorias.EliminarCategoria(Categoria);
                MessageBox.Show("Categoria Eliminada!","Operacion Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());

            }
            else
            {
                MessageBox.Show("Se cancelo la operacion","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void OpcionActualizar_Click(object sender, EventArgs e, int Categoria,string Nombre)
        {
            Frm_ActualizarCategoria abrir = new Frm_ActualizarCategoria(Categoria, Nombre);
            abrir.Show();
            this.Close();
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
                opcionEliminar.Click += (sender, e) => OpcionEliminar_Click(sender, e,categoria.No_Categoria,categoria.Nombre);
                opcionActualizar.Click +=(sender,e)=>OpcionActualizar_Click(sender,e,categoria.No_Categoria, categoria.Nombre);
                Opciones.Items.Add(opcionEliminar);
                Opciones.Items.Add(opcionActualizar);
                boton.Text = categoria.Nombre;
                boton.Tag = categoria.No_Categoria;
                boton.Size = new Size(140, 30);
                boton.Click += (sender, e) => BuscarProductos(sender, e, categoria.No_Categoria, categoria.Nombre);
                boton.ContextMenuStrip = Opciones;
                PanelBotonesC.Controls.Add(boton);
            }
        }
        #endregion
        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_NuevaCategoria abrir = new Frm_NuevaCategoria();
            abrir.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CBChico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                MessageBox.Show("No Categoria:"+_Productos.FKNo_Categoria+"\nNo: "+_Productos.No_Producto+
                    "\nProducto: "+_Productos.Producto+"\nImagen: "+_Productos.Imagen+"\nPrecio: "+_Productos.Precio+"\n"+
                    "Tamaño: "+_Productos.Tamaño);
                ControlProductos.AgregarProducto(_Productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            VaciarCajas();
            HabilitarElementos(true, true, true, true, true, false);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog cargararchivo = new OpenFileDialog())
            {
                cargararchivo.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (cargararchivo.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = cargararchivo.FileName;
                    string fileName = Path.GetFileName(sourceFilePath);
                    string targetDirectory = Path.Combine(Application.StartupPath, "Imagenes");
                    if (!Directory.Exists(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }
                    string targetFilePath = Path.Combine(targetDirectory, fileName);
                    File.Copy(sourceFilePath, targetFilePath, true);
                    Imagen.BackgroundImage = new Bitmap(targetFilePath);
                    Imagen.BackgroundImageLayout = ImageLayout.Stretch;
                    TxtRuta.Text = targetFilePath;
                }
            }
        }
    }
}
