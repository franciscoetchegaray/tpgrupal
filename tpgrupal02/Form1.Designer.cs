namespace tpgrupal02
{
    partial class formulariopunto2
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
            this.label3 = new System.Windows.Forms.Label();
            this.tLugar = new System.Windows.Forms.TextBox();
            this.tDistancia = new System.Windows.Forms.TextBox();
            this.tVelocidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese a donde viajara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la distancia en km:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la velocidad constante:";
            // 
            // tLugar
            // 
            this.tLugar.Location = new System.Drawing.Point(196, 47);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(100, 26);
            this.tLugar.TabIndex = 3;
            // 
            // tDistancia
            // 
            this.tDistancia.Location = new System.Drawing.Point(215, 92);
            this.tDistancia.Name = "tDistancia";
            this.tDistancia.Size = new System.Drawing.Size(100, 26);
            this.tDistancia.TabIndex = 4;
            // 
            // tVelocidad
            // 
            this.tVelocidad.Location = new System.Drawing.Point(246, 138);
            this.tVelocidad.Name = "tVelocidad";
            this.tVelocidad.Size = new System.Drawing.Size(100, 26);
            this.tVelocidad.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "calcular tiempo de viaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formulariopunto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tVelocidad);
            this.Controls.Add(this.tDistancia);
            this.Controls.Add(this.tLugar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formulariopunto2";
            this.Text = "Punto2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tLugar;
        private System.Windows.Forms.TextBox tDistancia;
        private System.Windows.Forms.TextBox tVelocidad;
        private System.Windows.Forms.Button button1;
    }
}

