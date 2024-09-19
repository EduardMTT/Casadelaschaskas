namespace CasaDeLasChaskas
{
    partial class Frm_Ventas
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
            this.DtgVentas = new System.Windows.Forms.DataGridView();
            this.DT1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgVentas
            // 
            this.DtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVentas.Location = new System.Drawing.Point(12, 53);
            this.DtgVentas.Name = "DtgVentas";
            this.DtgVentas.RowHeadersWidth = 62;
            this.DtgVentas.RowTemplate.Height = 28;
            this.DtgVentas.Size = new System.Drawing.Size(1147, 523);
            this.DtgVentas.TabIndex = 0;
            // 
            // DT1
            // 
            this.DT1.Location = new System.Drawing.Point(12, 21);
            this.DT1.Name = "DT1";
            this.DT1.Size = new System.Drawing.Size(310, 26);
            this.DT1.TabIndex = 2;
            this.DT1.ValueChanged += new System.EventHandler(this.DT1_ValueChanged);
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 598);
            this.Controls.Add(this.DT1);
            this.Controls.Add(this.DtgVentas);
            this.Name = "Frm_Ventas";
            this.Text = "Frm_Ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgVentas;
        private System.Windows.Forms.DateTimePicker DT1;
    }
}