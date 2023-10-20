namespace Proyecto_1._1
{
    partial class juego_topo
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
            this.components = new System.ComponentModel.Container();
            this.lblHit = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.Mole = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.iniciar_topo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.BackColor = System.Drawing.Color.Transparent;
            this.lblHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.Location = new System.Drawing.Point(978, 37);
            this.lblHit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(65, 37);
            this.lblHit.TabIndex = 0;
            this.lblHit.Text = "Hit:";
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.BackColor = System.Drawing.Color.Transparent;
            this.lblMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.Location = new System.Drawing.Point(978, 131);
            this.lblMiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(91, 37);
            this.lblMiss.TabIndex = 1;
            this.lblMiss.Text = "Miss:";
            // 
            // Mole
            // 
            this.Mole.BackColor = System.Drawing.Color.Transparent;
            this.Mole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mole.Image = global::Proyecto_1._1.Properties.Resources.alive;
            this.Mole.Location = new System.Drawing.Point(798, 422);
            this.Mole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mole.Name = "Mole";
            this.Mole.Size = new System.Drawing.Size(250, 254);
            this.Mole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mole.TabIndex = 2;
            this.Mole.TabStop = false;
            this.Mole.Click += new System.EventHandler(this.gotMole);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.movemole);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Proyecto_1._1.Properties.Resources.boton_volver_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 69);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iniciar_topo
            // 
            this.iniciar_topo.Location = new System.Drawing.Point(181, 37);
            this.iniciar_topo.Name = "iniciar_topo";
            this.iniciar_topo.Size = new System.Drawing.Size(146, 52);
            this.iniciar_topo.TabIndex = 4;
            this.iniciar_topo.Text = "Iniciar Topo";
            this.iniciar_topo.UseVisualStyleBackColor = true;
            this.iniciar_topo.Click += new System.EventHandler(this.iniciar_topo_Click);
            // 
            // juego_topo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_1._1.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 735);
            this.Controls.Add(this.iniciar_topo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mole);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "juego_topo";
            this.Text = "Juego Topo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.juego_topo_FormClosing);
            this.Load += new System.EventHandler(this.juego_topo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.PictureBox Mole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button iniciar_topo;
    }
}

