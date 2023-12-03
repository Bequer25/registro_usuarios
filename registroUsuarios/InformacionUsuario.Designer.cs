namespace registroUsuarios
{
    partial class InformacionUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApelllidoP = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(32, 21);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApelllidoP
            // 
            this.lblApelllidoP.AutoSize = true;
            this.lblApelllidoP.Location = new System.Drawing.Point(32, 51);
            this.lblApelllidoP.Name = "lblApelllidoP";
            this.lblApelllidoP.Size = new System.Drawing.Size(60, 13);
            this.lblApelllidoP.TabIndex = 1;
            this.lblApelllidoP.Text = "Apellido Pa";
            this.lblApelllidoP.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(32, 108);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(32, 80);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(62, 13);
            this.lblApellidoM.TabIndex = 3;
            this.lblApellidoM.Text = "Apellido Ma";
            // 
            // InformacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApelllidoP);
            this.Controls.Add(this.lblNombres);
            this.Name = "InformacionUsuario";
            this.Size = new System.Drawing.Size(283, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApelllidoP;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellidoM;
    }
}
