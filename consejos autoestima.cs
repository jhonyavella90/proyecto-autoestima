using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1._1
{
    public partial class consejos_autoestima : Form
    {
        private inicio inicio = null;
        private consejos_autoestima consejos_Autoestima = null;
        private menu menu = null;
        private Autoestima Autoestima = null;
        private PictureBox[] pictureBoxes;
        private Image[] pictureBoxesImgOrig;
        private int pictureBoxCount = 0;
        private int pictureOpacity = 0;

        public consejos_autoestima()
        {
            InitializeComponent();
        }

        private void consejos_autoestima_Load(object sender, EventArgs e)
        {
            consejos_Autoestima = new consejos_autoestima();
            inicio = new inicio();
            menu = new menu();
            Autoestima = new Autoestima();
            pictureBoxes = new PictureBox[4];
            pictureBoxesImgOrig = new Image[4];
            pictureBoxes[0] = pictureBox_corazon;
            pictureBoxes[1] = pictureBox_mente;
            pictureBoxes[2] = pictureBox_cuerpo;
            pictureBoxes[3] = pictureBox_espiritu;
            pictureBoxesImgOrig[0] = pictureBox_corazon.Image;
            pictureBoxesImgOrig[1] = pictureBox_mente.Image;
            pictureBoxesImgOrig[2] = pictureBox_cuerpo.Image;
            pictureBoxesImgOrig[3] = pictureBox_espiritu.Image;
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Hide();
           Autoestima.Show();
        }

        private void boton_corazon_Click(object sender, EventArgs e)
        {
            boton_corazon.Enabled = false;
            timer_single_image.Start();
        }

        private void timer_single_image_Tick(object sender, EventArgs e)
        {
            // Gradually increase the PictureBox control's Opacity property until it is fully visible.
            pictureBoxes[pictureBoxCount].Visible = true;

            SetImageOpacity(pictureBoxes[pictureBoxCount], pictureOpacity);

            // If the PictureBox control is fully visible, stop the Timer control.
            pictureOpacity += 32;
            if (pictureOpacity >= 256)
            {
                timer_single_image.Stop();
                pictureBoxCount += 1;
                pictureOpacity = 0;
                if (pictureBoxCount == pictureBoxes.Length) return;
                timer_single_image.Start();
            }
        }

        private void SetImageOpacity(PictureBox pictureBox, int opacity)
        {
            if (opacity > 255) opacity = 255;
            if (pictureBox.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBoxesImgOrig[pictureBoxCount]);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    if (pixel.A == 0 && pixel.R == 0 && pixel.G == 0 && pixel.G == 0) continue;
                    Color newColor = Color.FromArgb(opacity, pixel);
                    bmp.SetPixel(x, y, newColor);
                }
            }

            pictureBox.Image = bmp;
        }
    }
}
