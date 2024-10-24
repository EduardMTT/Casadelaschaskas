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

namespace CasaDeLasChaskas
{
    public partial class Frm_ActualizarCategoria : Form
    {
        Entidad_Categorias recibir;
        Categorias ControlCategorias;
        public Frm_ActualizarCategoria(int Categoria,string Nombre)
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
            recibir = new Entidad_Categorias();
            recibir.No_Categoria = Categoria;
            recibir.Nombre = Nombre;
        }

        private void Frm_ActualizarCategoria_Load(object sender, EventArgs e)
        {
            Etiqueta.Text=recibir.Nombre.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se cambiara el nombre de: " + recibir.Nombre + " al nombre: " + TxtNombreC.Text + "\n" +
                "¿Es correcto?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ControlCategorias.ActualizarCategoria(recibir.No_Categoria, TxtNombreC.Text);
                MessageBox.Show("Categoria Actualizada!", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmAgregarProductos abrir = new FrmAgregarProductos();
                this.Close();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Se cancelo la operacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
