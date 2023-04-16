namespace tpgrupal04
{
    partial class formpunto4
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tCantDeMb = new System.Windows.Forms.TextBox();
            this.pasarAGB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tNombreArchivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de megabytes para pasar a GB:";
            // 
            // tCantDeMb
            // 
            this.tCantDeMb.Location = new System.Drawing.Point(382, 46);
            this.tCantDeMb.Name = "tCantDeMb";
            this.tCantDeMb.Size = new System.Drawing.Size(100, 26);
            this.tCantDeMb.TabIndex = 1;
            // 
            // pasarAGB
            // 
            this.pasarAGB.Location = new System.Drawing.Point(40, 98);
            this.pasarAGB.Name = "pasarAGB";
            this.pasarAGB.Size = new System.Drawing.Size(141, 77);
            this.pasarAGB.TabIndex = 2;
            this.pasarAGB.Text = "Pasarlo a GB";
            this.pasarAGB.UseVisualStyleBackColor = true;
            this.pasarAGB.Click += new System.EventHandler(this.pasarAGB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el nombre del archivo:";
            // 
            // tNombreArchivo
            // 
            this.tNombreArchivo.Location = new System.Drawing.Point(238, 3);
            this.tNombreArchivo.Name = "tNombreArchivo";
            this.tNombreArchivo.Size = new System.Drawing.Size(100, 26);
            this.tNombreArchivo.TabIndex = 4;
            // 
            // formpunto4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tNombreArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pasarAGB);
            this.Controls.Add(this.tCantDeMb);
            this.Controls.Add(this.label1);
            this.Name = "formpunto4";
            this.Text = "Punto 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tCantDeMb;
        private System.Windows.Forms.Button pasarAGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNombreArchivo;
    }
}

