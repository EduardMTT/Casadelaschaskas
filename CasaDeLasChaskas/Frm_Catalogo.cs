using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections;

namespace CasaDeLasChaskas
{
    public partial class Frm_Catalogo : Form
    {
        Categorias ControlCategorias;
        Ventas ControlVentas;
        Productos ControlProductos;
        Entidad_Productos _Productos;
        Entidad_Ventas _Ventas;
        public Frm_Catalogo()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            ControlProductos = new Productos();
            ControlVentas = new Ventas();
            _Productos = new Entidad_Productos();
            _Ventas = new Entidad_Ventas();
        }
        string fechaActual;
        private void BuscarProductos(object sender, EventArgs e, int Categoria, string Nombre)
        {
            TablePanel.Controls.Clear();
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
                if (producto.Estatus.Equals("Activo"))
                {
                    Button boton = new Button();
                    string ruta = producto.Imagen;
                    boton.BackgroundImage = System.Drawing.Image.FromFile(ruta);
                    boton.BackgroundImageLayout = ImageLayout.Stretch;
                    boton.BackColor = Color.White;
                    boton.Font = new Font(boton.Font.FontFamily, 9);
                    boton.Tag = producto.No_Producto;
                    boton.Size = new Size(140, 140);
                    TablePanel.Controls.Add(boton);
                }
            }
        }
        public void CrearBotonesCategorias(List<Entidad_Categorias> categorias)
        {
            TablePanel.Controls.Clear();
            foreach (var categoria in categorias)
            {
                Button boton = new Button();
                boton.Text = categoria.Nombre;
                boton.Font = new Font("Yu Gothic", 13);
                boton.Tag = categoria.No_Categoria;
                boton.Size = new Size(140, 30);
                boton.Click += (sender, e) => BuscarProductos(sender, e, categoria.No_Categoria, categoria.Nombre);
                TablePanel.Controls.Add(boton);
            }
        }
        private void Frm_Catalogo_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;//1
            fechaActual = fecha.ToString("yyyy-MM-dd");//1
            //LblFecha.Text = fechaActual;//1
            // Crear las columnas para el carrito
            Carrito.Columns.Add("No_Producto", "No Producto");
            Carrito.Columns.Add("Producto", "Producto");
            Carrito.Columns.Add("Tamaño", "Tamaño");
            Carrito.Columns.Add("Precio", "Precio");
            Carrito.Columns.Add("Cantidad", "Cantidad");

            // Crear botón para aumentar cantidad (+)
            DataGridViewButtonColumn btnSumar = new DataGridViewButtonColumn();
            btnSumar.Name = "Sumar";
            btnSumar.HeaderText = "Agregar";
            btnSumar.Text = "+";
            btnSumar.UseColumnTextForButtonValue = true;
            Carrito.Columns.Add(btnSumar);

            // Crear botón para disminuir cantidad (-)
            DataGridViewButtonColumn btnRestar = new DataGridViewButtonColumn();
            btnRestar.Name = "Restar";
            btnRestar.HeaderText = "Quitar";
            btnRestar.Text = "-";
            btnRestar.UseColumnTextForButtonValue = true;
            Carrito.Columns.Add(btnRestar);

            // Crear botón para eliminar producto
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            Carrito.Columns.Add(btnEliminar);
            CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());
        }

       

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in Carrito.Rows)
            {
                // Verificar que la fila sea válida
                if (fila.Cells["Precio"].Value != null && fila.Cells["Cantidad"].Value != null)
                {
                    decimal precio;
                    int cantidad;
                    if (Decimal.TryParse(fila.Cells["Precio"].Value.ToString(), out precio) && Int32.TryParse(fila.Cells["Cantidad"].Value.ToString(), out cantidad))
                    {
                        total += precio * cantidad;
                    }
                }
            }

            // Mostrar el total en el txt_total
            txt_total.Text = total.ToString("0.00");
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas y columnas del DataGridView Carrito
            Carrito.Rows.Clear();
            // Opcional: Limpiar el total mostrado
            txt_total.Text = "0.00";
        }


        private void Carrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verificar si el clic fue en el botón de sumar, restar o eliminar
                if (Carrito.Columns[e.ColumnIndex].Name == "Sumar")
                {
                    // Aumentar la cantidad
                    int cantidadActual = Convert.ToInt32(Carrito.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    Carrito.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidadActual + 1;
                }
                else if (Carrito.Columns[e.ColumnIndex].Name == "Restar")
                {
                    // Disminuir la cantidad, no permitir cantidades menores a 1
                    int cantidadActual = Convert.ToInt32(Carrito.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    if (cantidadActual > 1)
                    {
                        Carrito.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidadActual - 1;
                    }
                }
                else if (Carrito.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Eliminar la fila seleccionada
                    if (MessageBox.Show("¿Desea eliminar este producto del carrito?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Carrito.Rows.RemoveAt(e.RowIndex);
                    }
                }

                // Recalcular el total después de cualquier acción
                CalcularTotal();
            }
        }

        //Definir el evento PrintDocument y el diálogo de vista previa
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        public void GuardarVentas()
        {
            int A = 0;
            int totalFilas = Carrito.RowCount;
            totalFilas = totalFilas - 1;//1
            do//2
            {
                if (A == totalFilas)//3
                {
                    break;
                }
                else//4
                {
                    if (A == 0)
                    {
                        //_Ventas.Fecha = LblFecha.Text;
                        _Ventas.Cliente = TxtCliente.Text;
                    }
                    _Ventas.PRODUCTO = int.Parse(Carrito.Rows[A].Cells[0].Value.ToString());
                    _Ventas.Cantidad = int.Parse(Carrito.Rows[A].Cells[4].Value.ToString());
                    _Ventas.Total = int.Parse(Carrito.Rows[A].Cells[4].Value.ToString()) * int.Parse(Carrito.Rows[A].Cells[3].Value.ToString());
                    ControlVentas.GuardarVenta(_Ventas);
                    _Ventas.Fecha = string.Empty;
                    A = A + 1;
                }
            } while (A < totalFilas);
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            btn_imprimir.Enabled = false;
            btn_cancelar.Enabled = false;
            GuardarVentas();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Mostrar la vista previa antes de imprimir
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            //Limpiar tabla y total
            Carrito.Rows.Clear();
            txt_total.Text = string.Empty;
            TxtPaga.Text = string.Empty;
            TxtCambio.Text = string.Empty;
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Configurar el formato y fuente de impresión con tamaños más grandes
            Font font = new Font("Arial", 25);
            Font fontBold = new Font("Arial", 27, FontStyle.Bold);
            int yPos = 40; // Posición vertical inicial
            int leftMargin = 10; // Reducir margen izquierdo manualmente

            // Título del ticket (nombre de la tienda)
            e.Graphics.DrawString(fechaActual, fontBold, Brushes.Black, leftMargin + 20, yPos);
            yPos += 70;
            e.Graphics.DrawString("********** CASA DE LAS CHASCAS **********", fontBold, Brushes.Black, leftMargin + 20, yPos);
            yPos += 100; // Incremento 

            // Dirección y datos de contacto
            e.Graphics.DrawString("Dirección: Calle Falsa 123", font, Brushes.Black, leftMargin + 200, yPos);
            yPos += 40;
            e.Graphics.DrawString("Tel: 123456789", font, Brushes.Black, leftMargin + 200, yPos);
            yPos += 40;
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), font, Brushes.Black, leftMargin + 200, yPos);
            yPos += 100;

            // Encabezados para los productos
            e.Graphics.DrawString("Cant", fontBold, Brushes.Black, leftMargin, yPos);
            e.Graphics.DrawString("Producto", fontBold, Brushes.Black, leftMargin + 150, yPos);
            e.Graphics.DrawString("Tamaño", fontBold, Brushes.Black, leftMargin + 400, yPos);
            e.Graphics.DrawString("Precio", fontBold, Brushes.Black, leftMargin + 690, yPos);
            yPos += 100;

            // Iterar sobre el carrito y dibujar cada producto
            foreach (DataGridViewRow fila in Carrito.Rows)
            {
                if (fila.Cells["Producto"].Value != null)
                {
                    string cantidad = fila.Cells["Cantidad"].Value.ToString();
                    string producto = fila.Cells["Producto"].Value.ToString();
                    string tamaño = fila.Cells["Tamaño"].Value.ToString();
                    string precio = fila.Cells["Precio"].Value.ToString();

                    // Ajustar las posiciones de acuerdo al tamaño de las fuentes
                    e.Graphics.DrawString(cantidad, font, Brushes.Black, leftMargin, yPos);
                    e.Graphics.DrawString(producto, font, Brushes.Black, leftMargin + 125, yPos);
                    e.Graphics.DrawString(tamaño, font, Brushes.Black, leftMargin + 375, yPos);
                    e.Graphics.DrawString(precio, font, Brushes.Black, leftMargin + 750, yPos);
                    yPos += 50;  // Incrementar más espacio entre filas debido al tamaño de la fuente
                }
            }

            // Línea de separación
            e.Graphics.DrawLine(new Pen(Color.Black), leftMargin, yPos, leftMargin + 800, yPos);
            yPos += 20;

            // Imprimir el total de la compra
            e.Graphics.DrawString("TOTAL: " + txt_total.Text + " MXN", fontBold, Brushes.Black, leftMargin + 400, yPos);
            yPos += 100;

            // Línea final
            e.Graphics.DrawString("¡Gracias por su compra "+TxtCliente.Text+"!", fontBold, Brushes.Black, leftMargin + 40, yPos);
            yPos += 40;
        }

        private void TxtPaga_TextChanged(object sender, EventArgs e)
        {
            if (TxtPaga.Text != string.Empty)
            {
                if (double.TryParse(TxtPaga.Text.ToString(), out double o))
                {
                    double cambio = double.Parse(TxtPaga.Text) - double.Parse(txt_total.Text);
                    TxtCambio.Text = cambio.ToString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtCambio_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TxtCambio.Text.ToString(), out double a))
            {
                if (a >= 0)
                {
                    btn_imprimir.Enabled = true;
                    btn_cancelar.Enabled = true;
                }
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            btn_imprimir.Enabled = false;
            btn_cancelar.Enabled = false;
            txt_total.Text = string.Empty;
            TxtPaga.Text = string.Empty;
            TxtCambio.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());
        }
    }
}
