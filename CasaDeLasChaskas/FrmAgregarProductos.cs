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
    public partial class FrmAgregarProductos : Form
    {
        Categorias ControlCategorias;
        Productos ControlProductos;
        Entidad_Productos _Productos;

        public FrmAgregarProductos()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            ControlProductos = new Productos();
            _Productos = new Entidad_Productos();
        }

        public void VaciarCajas()
        {
            txtnombredelproducto.Text = string.Empty;
            txtcosto.Text = string.Empty;
            txttamaño.Text = string.Empty;
            TxtRuta.Text = string.Empty;
            Imagen.Image = null;
            Imagen.BackgroundImage = null;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles
                string nombreProducto = txtnombredelproducto.Text.ToString();
                string tamaño = txttamaño.Text.ToString();
                decimal costo = decimal.Parse(txtcosto.Text.ToString());
                string imagenRuta = TxtRuta.Text.Replace("¥", "\\"); // Reemplazar separadores de ruta incorrectos
                string estatus = lblEstado.Text.ToString();
                int categoriaId = ControlCategorias.ObtenerCategoriaN(CBCategoria.Text);
                if (categoriaId == 0)
                {
                    MessageBox.Show("Error la categoria ingresada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ControlProductos.AgregarProducto(nombreProducto, tamaño, costo, imagenRuta, estatus, categoriaId);
                    MessageBox.Show("¡Producto guardado correctamente!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Frm_Prod abrir = new Frm_Prod();
                    abrir.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbactivo.Checked)
            {
                cbinactivo.Checked = false; // Desactivar cbInactivo si cbActivo está marcado
                lblEstado.Text = "Activo"; // Mostrar "Activo" en el TextBox
            }
            else
            {
                lblEstado.Text = ""; // Limpiar el TextBox si ninguno está seleccionado
            }
        }

        private void cbinactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbinactivo.Checked)
            {
                cbactivo.Checked = false; // Desactivar cbActivo si cbInactivo está marcado
                lblEstado.Text = "Inactivo"; // Mostrar "Inactivo" en el TextBox
            }
            else
            {
                lblEstado.Text = ""; // Limpiar el TextBox si ninguno está seleccionado
            }
        }
        public void CargarCOMBOBOX(List<Entidad_Categorias> categorias)
        {
            foreach(var categoria in categorias)
            {
                CBCategoria.Items.Add(categoria.Nombre);
            }
        }
        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {
            CargarCOMBOBOX(ControlCategorias.ObtenerCategorias());
            Color colorOriginal = Color.FromArgb(68, 42, 4);
            int alpha = (int)(255 * 0.69);
            Color colorDesvanecido = Color.FromArgb(alpha, colorOriginal.R, colorOriginal.G, colorOriginal.B);
            panel1.BackColor = colorDesvanecido;
        }

        private void btnagregarImagen_Click(object sender, EventArgs e)
        {
            Imagen.BackgroundImage = null;
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
                    TxtRuta.Text = targetFilePath;
                    string rutaCorrecta = TxtRuta.Text.Replace(@"¥", @"\");
                    rutaCorrecta = rutaCorrecta.Replace(@"\", @"\\");
                    TxtRuta.Text = rutaCorrecta;
                    btnagregarImagen.Visible = false;
                    Imagen.BackgroundImage = new Bitmap(TxtRuta.Text);
                    Imagen.BackColor = Color.Transparent;
                    Imagen.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void cbactivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbactivo.Checked)
            {
                cbinactivo.Checked = false; // Desactivar cbInactivo si cbActivo está marcado
                lblEstado.Text = "Activo"; // Mostrar "Activo" en el TextBox
            }
            else
            {
                lblEstado.Text = ""; // Limpiar el TextBox si ninguno está seleccionado
            }
        }

        private void cbinactivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbinactivo.Checked)
            {
                cbactivo.Checked = false; // Desactivar cbActivo si cbInactivo está marcado
                lblEstado.Text = "Inactivo"; // Mostrar "Inactivo" en el TextBox
            }
            else
            {
                lblEstado.Text = ""; // Limpiar el TextBox si ninguno está seleccionado
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo la operacion", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Prod abrir = new Frm_Prod();
            abrir.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
