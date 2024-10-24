namespace CasaDeLasChaskas
{
    partial class Frm_Catalogo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPaga = new System.Windows.Forms.TextBox();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablePanelC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Carrito = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(71, 7);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(239, 35);
            this.txt_total.TabIndex = 7;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.Black;
            this.btn_imprimir.Location = new System.Drawing.Point(624, 446);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(59, 30);
            this.btn_imprimir.TabIndex = 8;
            this.btn_imprimir.Text = "Pagar";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(687, 446);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 30);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar compra";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Paga:";
            // 
            // TxtPaga
            // 
            this.TxtPaga.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaga.Location = new System.Drawing.Point(106, 350);
            this.TxtPaga.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPaga.Name = "TxtPaga";
            this.TxtPaga.Size = new System.Drawing.Size(204, 35);
            this.TxtPaga.TabIndex = 11;
            this.TxtPaga.TextChanged += new System.EventHandler(this.TxtPaga_TextChanged);
            // 
            // TxtCambio
            // 
            this.TxtCambio.Enabled = false;
            this.TxtCambio.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCambio.Location = new System.Drawing.Point(106, 389);
            this.TxtCambio.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(204, 35);
            this.TxtCambio.TabIndex = 13;
            this.TxtCambio.TextChanged += new System.EventHandler(this.TxtCambio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cambio:";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(104, 11);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(313, 35);
            this.TxtCliente.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TablePanelC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 426);
            this.panel1.TabIndex = 18;
            // 
            // TablePanelC
            // 
            this.TablePanelC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePanelC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TablePanelC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePanelC.Location = new System.Drawing.Point(19, 48);
            this.TablePanelC.Margin = new System.Windows.Forms.Padding(2);
            this.TablePanelC.Name = "TablePanelC";
            this.TablePanelC.RowHeadersWidth = 51;
            this.TablePanelC.RowTemplate.Height = 24;
            this.TablePanelC.Size = new System.Drawing.Size(463, 363);
            this.TablePanelC.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Productos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(452, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.Carrito);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TxtCambio);
            this.panel2.Controls.Add(this.TxtPaga);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(518, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 430);
            this.panel2.TabIndex = 19;
            // 
            // Carrito
            // 
            this.Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Carrito.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Carrito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrito.Location = new System.Drawing.Point(7, 47);
            this.Carrito.Margin = new System.Windows.Forms.Padding(2);
            this.Carrito.Name = "Carrito";
            this.Carrito.RowHeadersWidth = 51;
            this.Carrito.RowTemplate.Height = 24;
            this.Carrito.Size = new System.Drawing.Size(303, 299);
            this.Carrito.TabIndex = 14;
            // 
            // Frm_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = global::CasaDeLasChaskas.Properties.Resources.imajen;
            this.ClientSize = new System.Drawing.Size(839, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(859, 547);
            this.Name = "Frm_Catalogo";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Frm_Catalogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPaga;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Carrito;
        private System.Windows.Forms.DataGridView TablePanelC;
    }
}