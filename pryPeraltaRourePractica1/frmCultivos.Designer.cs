namespace pryPeraltaRourePractica1
{
    partial class frmCultivos
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
            this.cboCultivos = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblCultivos = new System.Windows.Forms.Label();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCultivos
            // 
            this.cboCultivos.FormattingEnabled = true;
            this.cboCultivos.Location = new System.Drawing.Point(131, 12);
            this.cboCultivos.Name = "cboCultivos";
            this.cboCultivos.Size = new System.Drawing.Size(121, 21);
            this.cboCultivos.TabIndex = 0;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(12, 15);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(109, 13);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione Localidad";
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Location = new System.Drawing.Point(15, 51);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(82, 13);
            this.lblCultivos.TabIndex = 2;
            this.lblCultivos.Text = "Ingrese Cultivos";
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(131, 48);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(121, 20);
            this.txtCultivos.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(183, 88);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 124);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.cboCultivos);
            this.Name = "frmCultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar Cultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCultivos;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Button btnGrabar;
    }
}