namespace tpgrupal03
{
    partial class formpunto3
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
            this.label2 = new System.Windows.Forms.Label();
            this.tAncho = new System.Windows.Forms.TextBox();
            this.tAlto = new System.Windows.Forms.TextBox();
            this.CalcCantM3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tM3PorMetroCuadrado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el ancho de la pared:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el alto de la pared:";
            // 
            // tAncho
            // 
            this.tAncho.Location = new System.Drawing.Point(220, 0);
            this.tAncho.Name = "tAncho";
            this.tAncho.Size = new System.Drawing.Size(100, 26);
            this.tAncho.TabIndex = 2;
            // 
            // tAlto
            // 
            this.tAlto.Location = new System.Drawing.Point(220, 55);
            this.tAlto.Name = "tAlto";
            this.tAlto.Size = new System.Drawing.Size(100, 26);
            this.tAlto.TabIndex = 3;
            // 
            // CalcCantM3
            // 
            this.CalcCantM3.Location = new System.Drawing.Point(12, 133);
            this.CalcCantM3.Name = "CalcCantM3";
            this.CalcCantM3.Size = new System.Drawing.Size(162, 94);
            this.CalcCantM3.TabIndex = 4;
            this.CalcCantM3.Text = "Calcular la cantidad de m3 de arena utilizados";
            this.CalcCantM3.UseVisualStyleBackColor = true;
            this.CalcCantM3.Click += new System.EventHandler(this.CalcCantM3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese los m3 utilizados por metro cuadrado:";
            // 
            // tM3PorMetroCuadrado
            // 
            this.tM3PorMetroCuadrado.Location = new System.Drawing.Point(336, 87);
            this.tM3PorMetroCuadrado.Name = "tM3PorMetroCuadrado";
            this.tM3PorMetroCuadrado.Size = new System.Drawing.Size(100, 26);
            this.tM3PorMetroCuadrado.TabIndex = 6;
            // 
            // formpunto3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tM3PorMetroCuadrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalcCantM3);
            this.Controls.Add(this.tAlto);
            this.Controls.Add(this.tAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formpunto3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tAncho;
        private System.Windows.Forms.TextBox tAlto;
        private System.Windows.Forms.Button CalcCantM3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tM3PorMetroCuadrado;
    }
}

