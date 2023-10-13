namespace Proyecto_1._1
{
    partial class Form1
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
            this.boton_inicio = new System.Windows.Forms.Button();
            this.boton_juegos = new System.Windows.Forms.Button();
            this.boton_creditos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_inicio
            // 
            this.boton_inicio.Location = new System.Drawing.Point(919, 178);
            this.boton_inicio.Name = "boton_inicio";
            this.boton_inicio.Size = new System.Drawing.Size(130, 56);
            this.boton_inicio.TabIndex = 0;
            this.boton_inicio.Text = "Inicio";
            this.boton_inicio.UseVisualStyleBackColor = true;
            this.boton_inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_juegos
            // 
            this.boton_juegos.Location = new System.Drawing.Point(919, 264);
            this.boton_juegos.Name = "boton_juegos";
            this.boton_juegos.Size = new System.Drawing.Size(130, 56);
            this.boton_juegos.TabIndex = 1;
            this.boton_juegos.Text = "Juegos";
            this.boton_juegos.UseVisualStyleBackColor = true;
            // 
            // boton_creditos
            // 
            this.boton_creditos.Location = new System.Drawing.Point(919, 356);
            this.boton_creditos.Name = "boton_creditos";
            this.boton_creditos.Size = new System.Drawing.Size(130, 56);
            this.boton_creditos.TabIndex = 2;
            this.boton_creditos.Text = "Créditos";
            this.boton_creditos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1._1.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.boton_creditos);
            this.Controls.Add(this.boton_juegos);
            this.Controls.Add(this.boton_inicio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_inicio;
        private System.Windows.Forms.Button boton_juegos;
        private System.Windows.Forms.Button boton_creditos;
    }
}

