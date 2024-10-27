namespace CasaDeLasChaskas
{
    partial class Frm_Prod
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
            this.PanelCategorias = new System.Windows.Forms.GroupBox();
            this.PanelBotonesC = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAgregarCategoria = new System.Windows.Forms.Button();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelCategorias.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCategorias
            // 
            this.PanelCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(42)))), ((int)(((byte)(4)))));
            this.PanelCategorias.Controls.Add(this.PanelBotonesC);
            this.PanelCategorias.Controls.Add(this.BtnAgregarCategoria);
            this.PanelCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PanelCategorias.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCategorias.ForeColor = System.Drawing.SystemColors.Window;
            this.PanelCategorias.Location = new System.Drawing.Point(0, 0);
            this.PanelCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCategorias.Name = "PanelCategorias";
            this.PanelCategorias.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCategorias.Size = new System.Drawing.Size(294, 662);
            this.PanelCategorias.TabIndex = 4;
            this.PanelCategorias.TabStop = false;
            this.PanelCategorias.Text = "Categorias";
            // 
            // PanelBotonesC
            // 
            this.PanelBotonesC.AutoScroll = true;
            this.PanelBotonesC.Location = new System.Drawing.Point(4, 46);
            this.PanelBotonesC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelBotonesC.Name = "PanelBotonesC";
            this.PanelBotonesC.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PanelBotonesC.Size = new System.Drawing.Size(282, 540);
            this.PanelBotonesC.TabIndex = 0;
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCategoria.ForeColor = System.Drawing.Color.Indigo;
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(6, 595);
            this.BtnAgregarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(282, 42);
            this.BtnAgregarCategoria.TabIndex = 1;
            this.BtnAgregarCategoria.Text = "Nueva Categoria";
            this.BtnAgregarCategoria.UseVisualStyleBackColor = true;
            this.BtnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.BackColor = System.Drawing.SystemColors.Info;
            this.TablePanel.ColumnCount = 3;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TablePanel.Location = new System.Drawing.Point(28, 36);
            this.TablePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 4;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanel.Size = new System.Drawing.Size(755, 520);
            this.TablePanel.TabIndex = 5;
            this.TablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablePanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TablePanel);
            this.panel1.Location = new System.Drawing.Point(323, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 590);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CasaDeLasChaskas.Properties.Resources.Agregar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(825, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 58);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(42)))), ((int)(((byte)(4)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(323, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos";
            // 
            // Frm_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasaDeLasChaskas.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1249, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_Prod_Load);
            this.PanelCategorias.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PanelBotonesC;
        private System.Windows.Forms.Button BtnAgregarCategoria;
        private System.Windows.Forms.GroupBox PanelCategorias;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}