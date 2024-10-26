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
    public partial class Frm_NuevaCategoria : Form
    {
        Categorias ControlCategorias;
        public Frm_NuevaCategoria()
        {
            InitializeComponent();
            ControlCategorias = new Categorias();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ControlCategorias.GuardarCategoria(TxtNombreC.Text);
            MessageBox.Show(TxtNombreC.Text+" Se a guardado exitosamente");
            this.Close();

            Frm_Prod rfmm = new Frm_Prod();
            rfmm.Show();
        }

        private void Frm_NuevaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
