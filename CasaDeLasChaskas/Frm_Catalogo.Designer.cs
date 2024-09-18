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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TablePanelC = new System.Windows.Forms.DataGridView();
            this.Carrito = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPaga = new System.Windows.Forms.TextBox();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelCategorias = new System.Windows.Forms.GroupBox();
            this.PanelBotonesC = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).BeginInit();
            this.PanelCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrito del cliente:";
            // 
            // TablePanelC
            // 
            this.TablePanelC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePanelC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePanelC.Location = new System.Drawing.Point(324, 60);
            this.TablePanelC.Name = "TablePanelC";
            this.TablePanelC.RowHeadersWidth = 51;
            this.TablePanelC.RowTemplate.Height = 24;
            this.TablePanelC.Size = new System.Drawing.Size(900, 251);
            this.TablePanelC.TabIndex = 4;
            // 
            // Carrito
            // 
            this.Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrito.Location = new System.Drawing.Point(324, 362);
            this.Carrito.Name = "Carrito";
            this.Carrito.RowHeadersWidth = 51;
            this.Carrito.RowTemplate.Height = 24;
            this.Carrito.Size = new System.Drawing.Size(900, 245);
            this.Carrito.TabIndex = 5;
            this.Carrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Carrito_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(449, 630);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(151, 26);
            this.txt_total.TabIndex = 7;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(899, 12);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(162, 43);
            this.btn_imprimir.TabIndex = 8;
            this.btn_imprimir.Text = "Cobrar e Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(1067, 11);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(152, 43);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar compra";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Paga:";
            // 
            // TxtPaga
            // 
            this.TxtPaga.Location = new System.Drawing.Point(716, 630);
            this.TxtPaga.Name = "TxtPaga";
            this.TxtPaga.Size = new System.Drawing.Size(151, 26);
            this.TxtPaga.TabIndex = 11;
            this.TxtPaga.TextChanged += new System.EventHandler(this.TxtPaga_TextChanged);
            // 
            // TxtCambio
            // 
            this.TxtCambio.Enabled = false;
            this.TxtCambio.Location = new System.Drawing.Point(995, 630);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(151, 26);
            this.TxtCambio.TabIndex = 13;
            this.TxtCambio.TextChanged += new System.EventHandler(this.TxtCambio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(873, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cambio:";
            // 
            // PanelCategorias
            // 
            this.PanelCategorias.Controls.Add(this.PanelBotonesC);
            this.PanelCategorias.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCategorias.Location = new System.Drawing.Point(12, 12);
            this.PanelCategorias.Name = "PanelCategorias";
            this.PanelCategorias.Size = new System.Drawing.Size(294, 659);
            this.PanelCategorias.TabIndex = 14;
            this.PanelCategorias.TabStop = false;
            this.PanelCategorias.Text = "Categorias";
            // 
            // PanelBotonesC
            // 
            this.PanelBotonesC.AutoScroll = true;
            this.PanelBotonesC.Location = new System.Drawing.Point(4, 46);
            this.PanelBotonesC.Name = "PanelBotonesC";
            this.PanelBotonesC.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PanelBotonesC.Size = new System.Drawing.Size(282, 600);
            this.PanelBotonesC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(623, 13);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(20, 20);
            this.LblFecha.TabIndex = 16;
            this.LblFecha.Text = "X";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(602, 330);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(208, 26);
            this.TxtCliente.TabIndex = 17;
            // 
            // Frm_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 764);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelCategorias);
            this.Controls.Add(this.TxtCambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.TablePanelC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(1280, 820);
            this.Name = "Frm_Catalogo";
            this.Text = "Frm_Catalogo";
            this.Load += new System.EventHandler(this.Frm_Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).EndInit();
            this.PanelCategorias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TablePanelC;
        private System.Windows.Forms.DataGridView Carrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPaga;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox PanelCategorias;
        private System.Windows.Forms.FlowLayoutPanel PanelBotonesC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtCliente;
    }
}