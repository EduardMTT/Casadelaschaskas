﻿namespace CasaDeLasChaskas
{
    partial class FrmAgregarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.btnagregarImagen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.cbinactivo = new System.Windows.Forms.CheckBox();
            this.cbactivo = new System.Windows.Forms.CheckBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombredelproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel_titulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_titulo.Controls.Add(this.lbl_titulo);
            this.panel_titulo.Location = new System.Drawing.Point(0, -2);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(514, 66);
            this.panel_titulo.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(95, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(318, 39);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Agregar productos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.TxtRuta);
            this.panel1.Controls.Add(this.btnagregarImagen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Imagen);
            this.panel1.Controls.Add(this.cbinactivo);
            this.panel1.Controls.Add(this.cbactivo);
            this.panel1.Controls.Add(this.txtcosto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txttamaño);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnombredelproducto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcategoria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 589);
            this.panel1.TabIndex = 1;
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(21, 328);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(204, 22);
            this.TxtRuta.TabIndex = 4;
            // 
            // btnagregarImagen
            // 
            this.btnagregarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarImagen.BackgroundImage = global::CasaDeLasChaskas.Properties.Resources.Agregar;
            this.btnagregarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarImagen.Location = new System.Drawing.Point(80, 404);
            this.btnagregarImagen.Name = "btnagregarImagen";
            this.btnagregarImagen.Size = new System.Drawing.Size(89, 83);
            this.btnagregarImagen.TabIndex = 12;
            this.btnagregarImagen.UseVisualStyleBackColor = false;
            this.btnagregarImagen.Click += new System.EventHandler(this.btnagregarImagen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imagen";
            // 
            // Imagen
            // 
            this.Imagen.BackColor = System.Drawing.Color.SaddleBrown;
            this.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen.Location = new System.Drawing.Point(21, 356);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(204, 186);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 10;
            this.Imagen.TabStop = false;
            // 
            // cbinactivo
            // 
            this.cbinactivo.AutoSize = true;
            this.cbinactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbinactivo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinactivo.ForeColor = System.Drawing.Color.White;
            this.cbinactivo.Location = new System.Drawing.Point(269, 419);
            this.cbinactivo.Name = "cbinactivo";
            this.cbinactivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbinactivo.Size = new System.Drawing.Size(115, 27);
            this.cbinactivo.TabIndex = 9;
            this.cbinactivo.Text = "Inactivo";
            this.cbinactivo.UseVisualStyleBackColor = true;
            this.cbinactivo.CheckedChanged += new System.EventHandler(this.cbinactivo_CheckedChanged_1);
            // 
            // cbactivo
            // 
            this.cbactivo.AutoSize = true;
            this.cbactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbactivo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbactivo.ForeColor = System.Drawing.Color.White;
            this.cbactivo.Location = new System.Drawing.Point(288, 371);
            this.cbactivo.Name = "cbactivo";
            this.cbactivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbactivo.Size = new System.Drawing.Size(96, 27);
            this.cbactivo.TabIndex = 8;
            this.cbactivo.Text = "Activo";
            this.cbactivo.UseVisualStyleBackColor = true;
            this.cbactivo.CheckedChanged += new System.EventHandler(this.cbactivo_CheckedChanged_1);
            // 
            // txtcosto
            // 
            this.txtcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcosto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(21, 282);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(363, 32);
            this.txtcosto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo";
            // 
            // txttamaño
            // 
            this.txttamaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttamaño.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttamaño.Location = new System.Drawing.Point(21, 201);
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(363, 32);
            this.txttamaño.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamaño";
            // 
            // txtnombredelproducto
            // 
            this.txtnombredelproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombredelproducto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombredelproducto.Location = new System.Drawing.Point(21, 120);
            this.txtnombredelproducto.Name = "txtnombredelproducto";
            this.txtnombredelproducto.Size = new System.Drawing.Size(363, 32);
            this.txtnombredelproducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto";
            // 
            // txtcategoria
            // 
            this.txtcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoria.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(21, 45);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(363, 32);
            this.txtcategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(397, 698);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(104, 38);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.Location = new System.Drawing.Point(287, 698);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(104, 38);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(296, 464);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(34, 23);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "---";
            // 
            // FrmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasaDeLasChaskas.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(513, 748);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titulo);
            this.Name = "FrmAgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarProductos";
            this.Load += new System.EventHandler(this.FrmAgregarProductos_Load);
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombredelproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbinactivo;
        private System.Windows.Forms.CheckBox cbactivo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregarImagen;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.Label lblEstado;
    }
}