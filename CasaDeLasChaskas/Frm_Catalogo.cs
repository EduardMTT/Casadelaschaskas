using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//referencia para hacer la imprecion
using System.Drawing.Printing;

namespace CasaDeLasChaskas
{
    public partial class Frm_Catalogo : Form
    {
        Categorias ControlCategorias;
        Productos ControlProductos;
        Entidad_Productos _Productos;

        public Frm_Catalogo()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            ControlProductos = new Productos();
            _Productos = new Entidad_Productos();
            TablePanelC.CellContentClick += TablePanelC_CellContentClick;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);


        }

        private void Frm_Catalogo_Load(object sender, EventArgs e)
        {
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

            // Llenar las categorías
            CrearBotonesCategorias(ControlCategorias.ObtenerCategorias());
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

        public void OpcionActualizar_Click(object sender, EventArgs e, int Categoria, string Nombre)
        {
            Frm_ActualizarCategoria abrir = new Frm_ActualizarCategoria(Categoria, Nombre);
            abrir.Show();
            this.Close();
        }

        public void CrearBotonesCategorias(List<Entidad_Categorias> categorias)
        {
            PanelBotonesC_2.Controls.Clear();
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
                boton.Tag = categoria.No_Categoria;
                boton.Size = new Size(140, 30);
                boton.ContextMenuStrip = Opciones;

                // Evento click para mostrar los productos de la categoría
                boton.Click += (sender, e) => MostrarProductosPorCategoria((int)boton.Tag);

                PanelBotonesC_2.Controls.Add(boton);
            }
        }

        private void MostrarProductosPorCategoria(int categoriaId)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            TablePanelC.Columns.Clear();
            TablePanelC.Rows.Clear();

            // Agregar columnas para las propiedades
            TablePanelC.Columns.Add("No_Producto", "No Producto");
            TablePanelC.Columns.Add("Producto", "Producto");
            TablePanelC.Columns.Add("Tamaño", "Tamaño");
            TablePanelC.Columns.Add("Precio", "Precio");

            // Crear una columna de imagen
            DataGridViewImageColumn imagenColumna = new DataGridViewImageColumn();
            imagenColumna.HeaderText = "Imagen";
            imagenColumna.Name = "Imagen";
            imagenColumna.ImageLayout = DataGridViewImageCellLayout.Zoom;
            TablePanelC.Columns.Add(imagenColumna);

            // Crear una columna de botones para agregar al carrito
            DataGridViewButtonColumn botonAgregar = new DataGridViewButtonColumn();
            botonAgregar.HeaderText = "Agregar al Carrito";
            botonAgregar.Text = "Agregar";
            botonAgregar.Name = "Agregar";
            botonAgregar.UseColumnTextForButtonValue = true;
            TablePanelC.Columns.Add(botonAgregar);

            // Obtener los productos de la categoría seleccionada
            List<Entidad_Productos> productos = ControlProductos.ObtenerProductos(categoriaId);

            // Llenar el DataGridView con los productos
            foreach (var producto in productos)
            {
                // Cargar la imagen desde la ruta guardada en la base de datos
                Image imagenProducto = null;
                if (File.Exists(producto.Imagen))
                {
                    imagenProducto = Image.FromFile(producto.Imagen);
                }

                // Agregar una fila con los datos y la imagen
                TablePanelC.Rows.Add(producto.No_Producto, producto.Producto, producto.Tamaño, producto.Precio, imagenProducto);
            }

            // Ajustar el tamaño de las columnas si es necesario
            TablePanelC.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void TablePanelC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic fue en el botón de agregar
                if (TablePanelC.Columns[e.ColumnIndex].Name == "Agregar")
                {
                    // Obtener los valores de la fila seleccionada
                    int noProducto = Convert.ToInt32(TablePanelC.Rows[e.RowIndex].Cells["No_Producto"].Value);
                    string producto = TablePanelC.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    string tamaño = TablePanelC.Rows[e.RowIndex].Cells["Tamaño"].Value.ToString();
                    decimal precio = Convert.ToDecimal(TablePanelC.Rows[e.RowIndex].Cells["Precio"].Value);

                    // Agregar el producto al carrito con cantidad 1
                    Carrito.Rows.Add(noProducto, producto, tamaño, precio, 1);

                    // Recalcular el total
                    CalcularTotal();
                }
            }
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
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            // Configurar el documento a imprimir
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Mostrar la vista previa antes de imprimir
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            //Limpiar tabla y total
            Carrito.Rows.Clear();
            txt_total.Text = "0.00";
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Configurar el formato y fuente de impresión con tamaños más grandes
            Font font = new Font("Arial", 25);
            Font fontBold = new Font("Arial", 27, FontStyle.Bold);
            int yPos = 100; // Posición vertical inicial
            int leftMargin = 10; // Reducir margen izquierdo manualmente

            // Título del ticket (nombre de la tienda)
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
            e.Graphics.DrawString("¡Gracias por su compra!", fontBold, Brushes.Black, leftMargin + 40, yPos);
            yPos += 40;
        }
    }
}
