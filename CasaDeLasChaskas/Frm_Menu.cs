﻿using System;
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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void tsm_productos_Click(object sender, EventArgs e)
        {
            Frm_Productos abrir = new Frm_Productos();
            abrir.Show();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            //ZZZZZZZZZZZZ
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Catalogo frm_Catalogo = new Frm_Catalogo();
            frm_Catalogo.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ventas abrir = new Frm_Ventas();
            abrir.Show();
        }
    }
}
