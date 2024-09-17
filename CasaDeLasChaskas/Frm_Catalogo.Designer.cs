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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelBotonesC_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TablePanelC = new System.Windows.Forms.DataGridView();
            this.Carrito = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catalogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrito";
            // 
            // PanelBotonesC_2
            // 
            this.PanelBotonesC_2.Location = new System.Drawing.Point(9, 39);
            this.PanelBotonesC_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelBotonesC_2.Name = "PanelBotonesC_2";
            this.PanelBotonesC_2.Size = new System.Drawing.Size(115, 466);
            this.PanelBotonesC_2.TabIndex = 3;
            // 
            // TablePanelC
            // 
            this.TablePanelC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePanelC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePanelC.Location = new System.Drawing.Point(145, 39);
            this.TablePanelC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TablePanelC.Name = "TablePanelC";
            this.TablePanelC.RowHeadersWidth = 51;
            this.TablePanelC.RowTemplate.Height = 24;
            this.TablePanelC.Size = new System.Drawing.Size(783, 163);
            this.TablePanelC.TabIndex = 4;
            // 
            // Carrito
            // 
            this.Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carrito.Location = new System.Drawing.Point(145, 260);
            this.Carrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Carrito.Name = "Carrito";
            this.Carrito.RowHeadersWidth = 51;
            this.Carrito.RowTemplate.Height = 24;
            this.Carrito.Size = new System.Drawing.Size(783, 159);
            this.Carrito.TabIndex = 5;
            this.Carrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Carrito_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(806, 438);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(102, 20);
            this.txt_total.TabIndex = 7;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(749, 476);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(67, 28);
            this.btn_imprimir.TabIndex = 8;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(839, 476);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(67, 28);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 514);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.TablePanelC);
            this.Controls.Add(this.PanelBotonesC_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Catalogo";
            this.Text = "Frm_Catalogo";
            this.Load += new System.EventHandler(this.Frm_Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanelC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PanelBotonesC_2;
        private System.Windows.Forms.DataGridView TablePanelC;
        private System.Windows.Forms.DataGridView Carrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
    }
}