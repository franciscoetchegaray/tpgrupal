namespace tpgrupal01
{
    partial class formulario
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
            this.labeluno = new System.Windows.Forms.Label();
            this.labeldos = new System.Windows.Forms.Label();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.tUnidad = new System.Windows.Forms.TextBox();
            this.calcperimetro = new System.Windows.Forms.Button();
            this.botonarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeluno
            // 
            this.labeluno.AutoSize = true;
            this.labeluno.Location = new System.Drawing.Point(12, 54);
            this.labeluno.Name = "labeluno";
            this.labeluno.Size = new System.Drawing.Size(122, 20);
            this.labeluno.TabIndex = 0;
            this.labeluno.Text = "Ingrese el radio:";
            // 
            // labeldos
            // 
            this.labeldos.AutoSize = true;
            this.labeldos.Location = new System.Drawing.Point(12, 95);
            this.labeldos.Name = "labeldos";
            this.labeldos.Size = new System.Drawing.Size(275, 20);
            this.labeldos.TabIndex = 1;
            this.labeldos.Text = "ingrese el tipo de unidad(cm, m o km):";
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(140, 48);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(100, 26);
            this.tRadio.TabIndex = 2;
            this.tRadio.TextChanged += new System.EventHandler(this.tRadio_TextChanged);
            // 
            // tUnidad
            // 
            this.tUnidad.Location = new System.Drawing.Point(293, 95);
            this.tUnidad.Name = "tUnidad";
            this.tUnidad.Size = new System.Drawing.Size(100, 26);
            this.tUnidad.TabIndex = 3;
            // 
            // calcperimetro
            // 
            this.calcperimetro.Location = new System.Drawing.Point(16, 145);
            this.calcperimetro.Name = "calcperimetro";
            this.calcperimetro.Size = new System.Drawing.Size(161, 92);
            this.calcperimetro.TabIndex = 4;
            this.calcperimetro.Text = "Calcular el perimetro del circulo";
            this.calcperimetro.UseVisualStyleBackColor = true;
            this.calcperimetro.Click += new System.EventHandler(this.calcperimetro_Click);
            // 
            // botonarea
            // 
            this.botonarea.Location = new System.Drawing.Point(226, 145);
            this.botonarea.Name = "botonarea";
            this.botonarea.Size = new System.Drawing.Size(167, 92);
            this.botonarea.TabIndex = 5;
            this.botonarea.Text = "Calcular el area";
            this.botonarea.UseVisualStyleBackColor = true;
            this.botonarea.Click += new System.EventHandler(this.botonarea_Click);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonarea);
            this.Controls.Add(this.calcperimetro);
            this.Controls.Add(this.tUnidad);
            this.Controls.Add(this.tRadio);
            this.Controls.Add(this.labeldos);
            this.Controls.Add(this.labeluno);
            this.Name = "formulario";
            this.Text = "EJERCICIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeluno;
        private System.Windows.Forms.Label labeldos;
        private System.Windows.Forms.TextBox tRadio;
        private System.Windows.Forms.TextBox tUnidad;
        private System.Windows.Forms.Button calcperimetro;
        private System.Windows.Forms.Button botonarea;
    }
}

