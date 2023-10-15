namespace Proyecto_1._1
{
    partial class inicio
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
            this.boton_creditos = new System.Windows.Forms.Button();
            this.boton_de_juegos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_inicio
            // 
            this.boton_inicio.BackColor = System.Drawing.Color.Transparent;
            this.boton_inicio.BackgroundImage = global::Proyecto_1._1.Properties.Resources.Inicio_29_8_2023;
            this.boton_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_inicio.FlatAppearance.BorderSize = 0;
            this.boton_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_inicio.Location = new System.Drawing.Point(863, 66);
            this.boton_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.boton_inicio.Name = "boton_inicio";
            this.boton_inicio.Size = new System.Drawing.Size(250, 123);
            this.boton_inicio.TabIndex = 0;
            this.boton_inicio.UseVisualStyleBackColor = false;
            this.boton_inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_creditos
            // 
            this.boton_creditos.BackColor = System.Drawing.Color.Transparent;
            this.boton_creditos.BackgroundImage = global::Proyecto_1._1.Properties.Resources.Creditos_13_10_2023;
            this.boton_creditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_creditos.FlatAppearance.BorderSize = 0;
            this.boton_creditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_creditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_creditos.Location = new System.Drawing.Point(880, 294);
            this.boton_creditos.Margin = new System.Windows.Forms.Padding(2);
            this.boton_creditos.Name = "boton_creditos";
            this.boton_creditos.Size = new System.Drawing.Size(261, 132);
            this.boton_creditos.TabIndex = 2;
            this.boton_creditos.UseVisualStyleBackColor = false;
            this.boton_creditos.Click += new System.EventHandler(this.boton_creditos_Click);
            // 
            // boton_de_juegos
            // 
            this.boton_de_juegos.BackColor = System.Drawing.Color.Transparent;
            this.boton_de_juegos.BackgroundImage = global::Proyecto_1._1.Properties.Resources.output;
            this.boton_de_juegos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_de_juegos.FlatAppearance.BorderSize = 0;
            this.boton_de_juegos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_de_juegos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton_de_juegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_de_juegos.Location = new System.Drawing.Point(823, 159);
            this.boton_de_juegos.Margin = new System.Windows.Forms.Padding(2);
            this.boton_de_juegos.Name = "boton_de_juegos";
            this.boton_de_juegos.Size = new System.Drawing.Size(492, 178);
            this.boton_de_juegos.TabIndex = 3;
            this.boton_de_juegos.UseVisualStyleBackColor = false;
            this.boton_de_juegos.Click += new System.EventHandler(this.boton_de_juegos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proyecto_1._1.Properties.Resources.Eleva_Tu_Ser_13_10_2023__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 406);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1._1.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boton_creditos);
            this.Controls.Add(this.boton_inicio);
            this.Controls.Add(this.boton_de_juegos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_inicio;
        private System.Windows.Forms.Button boton_creditos;
        private System.Windows.Forms.Button boton_de_juegos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

