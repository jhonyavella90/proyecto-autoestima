using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Proyecto_1._1
{
    public partial class consejos_autocon : Form
    {
        private menu menu = null;
        private Autoconfianza autoconfianza = null;
        private consejos_autocon consejos_Autocon = null;
        private Label[] mainLabels;
        private int[] originalPositions;
        private int labelCount = 0;
        private int deltaY = 10;

        public consejos_autocon()
        {
            InitializeComponent();
        }

        private void consejos_autocon_Load(object sender, EventArgs e)
        {
            autoconfianza = new Autoconfianza();
            menu = new menu();
            consejos_Autocon = new consejos_autocon();

            mainLabels = new Label[4];
            originalPositions = new int[4];
            originalPositions[0] = label_baila.Location.Y;
            originalPositions[1] = label_descansa.Location.Y;
            originalPositions[2] = label_agradece.Location.Y;
            originalPositions[3] = label_relajate.Location.Y;
            mainLabels[0] = label_baila;
            mainLabels[1] = label_descansa;
            mainLabels[2] = label_agradece;
            mainLabels[3] = label_relajate;
            for (int i = 0; i < mainLabels.Length; i++)
            {
                mainLabels[i].Visible = false;
                mainLabels[i].Location = new Point(mainLabels[i].Location.X, this.Height - mainLabels[i].Height);
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            autoconfianza.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainLabels[labelCount].Visible = true;

            // Move the Button control closer to the target Y position.
            int currentY = mainLabels[labelCount].Location.Y;

            if (currentY - originalPositions[labelCount] <= deltaY)
            {
                currentY = originalPositions[labelCount];
            } else
            {
                currentY -= deltaY;
            }

            mainLabels[labelCount].Location = new Point(mainLabels[labelCount].Location.X, currentY);

            // If the Button control has reached the target Y position, stop the Timer control.
            if (currentY == originalPositions[labelCount])
            {
                timer1.Stop();
                labelCount++;
                if (labelCount == mainLabels.Length) return;
                timer1.Start();
            }
        }
    }
}
