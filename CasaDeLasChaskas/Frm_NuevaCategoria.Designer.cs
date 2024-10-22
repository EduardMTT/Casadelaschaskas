namespace CasaDeLasChaskas
{
    partial class Frm_NuevaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevaCategoria));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(153, 171);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(98, 35);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Como se llamara tu nueva categoria de productos";
            // 
            // TxtNombreC
            // 
            this.TxtNombreC.Location = new System.Drawing.Point(68, 122);
            this.TxtNombreC.Name = "TxtNombreC";
            this.TxtNombreC.Size = new System.Drawing.Size(280, 26);
            this.TxtNombreC.TabIndex = 2;
            // 
            // Frm_NuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(424, 290);
            this.Controls.Add(this.TxtNombreC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_NuevaCategoria";
            this.Text = "Nueva Categoria";
            this.Load += new System.EventHandler(this.Frm_NuevaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreC;
    }
}