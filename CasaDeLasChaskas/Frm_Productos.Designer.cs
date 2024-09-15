namespace CasaDeLasChaskas
{
    partial class Frm_Productos
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelCategorias = new System.Windows.Forms.GroupBox();
            this.PanelBotonesC = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAgregarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(895, 36);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 62;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.Size = new System.Drawing.Size(263, 216);
            this.Grid.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TablePanel);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(301, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 650);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.ColumnCount = 3;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TablePanel.Location = new System.Drawing.Point(6, 46);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 4;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.Size = new System.Drawing.Size(582, 598);
            this.TablePanel.TabIndex = 2;
            // 
            // PanelCategorias
            // 
            this.PanelCategorias.Controls.Add(this.PanelBotonesC);
            this.PanelCategorias.Controls.Add(this.BtnAgregarCategoria);
            this.PanelCategorias.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCategorias.Location = new System.Drawing.Point(1, 12);
            this.PanelCategorias.Name = "PanelCategorias";
            this.PanelCategorias.Size = new System.Drawing.Size(294, 650);
            this.PanelCategorias.TabIndex = 3;
            this.PanelCategorias.TabStop = false;
            this.PanelCategorias.Text = "Categorias";
            // 
            // PanelBotonesC
            // 
            this.PanelBotonesC.AutoScroll = true;
            this.PanelBotonesC.Location = new System.Drawing.Point(4, 46);
            this.PanelBotonesC.Name = "PanelBotonesC";
            this.PanelBotonesC.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PanelBotonesC.Size = new System.Drawing.Size(282, 540);
            this.PanelBotonesC.TabIndex = 0;
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(6, 595);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(282, 35);
            this.BtnAgregarCategoria.TabIndex = 1;
            this.BtnAgregarCategoria.Text = "Nueva Categoria";
            this.BtnAgregarCategoria.UseVisualStyleBackColor = true;
            this.BtnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 665);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelCategorias);
            this.Name = "Frm_Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.PanelCategorias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.GroupBox PanelCategorias;
        private System.Windows.Forms.FlowLayoutPanel PanelBotonesC;
        private System.Windows.Forms.Button BtnAgregarCategoria;
    }
}