﻿namespace CasaDeLasChaskas
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgVentas
            // 
            this.DtgVentas.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
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
            this.DT1.CalendarMonthBackground = System.Drawing.Color.Cornsilk;
            this.DT1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT1.Location = new System.Drawing.Point(12, 12);
            this.DT1.Name = "DT1";
            this.DT1.Size = new System.Drawing.Size(411, 34);
            this.DT1.TabIndex = 2;
            this.DT1.ValueChanged += new System.EventHandler(this.DT1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(912, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas Totales:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(1102, 16);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(24, 26);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1077, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1208, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT1);
            this.Controls.Add(this.DtgVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Ventas";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgVentas;
        private System.Windows.Forms.DateTimePicker DT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label2;
    }
}