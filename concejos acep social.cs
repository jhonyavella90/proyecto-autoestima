﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1._1
{
    public partial class concejos_acep_social : Form
    {
        private aceptacion_social aceptacion_Social = null;
        private menu menu=null;
        private PictureBox[] pictureBoxes;
        private Image[] pictureBoxesImgOrig;
        private int pictureBoxCount = 0;
        private int pictureOpacity = 0;

        public concejos_acep_social()
        {
            InitializeComponent();
        }

        private void concejos_acep_social_Load(object sender, EventArgs e)
        {
            aceptacion_Social = new aceptacion_social();
            menu = new menu();
            pictureBoxes = new PictureBox[6];
            pictureBoxesImgOrig = new Image[6];
            pictureBoxes[0] = pictureBox_liderazgo;
            pictureBoxes[1] = pictureBox_compasivo;
            pictureBoxes[2] = pictureBox_vida;
            pictureBoxes[3] = pictureBox_cree;
            pictureBoxes[4] = pictureBox_divertido;
            pictureBoxes[5] = pictureBox_cuerpo;
            pictureBoxes[6] = pictureBox_explora;
            pictureBoxes[7] = pictureBox_freacaso;
            pictureBoxesImgOrig[0] = pictureBox_liderazgo.Image;
            pictureBoxesImgOrig[1] = pictureBox_compasivo.Image;
            pictureBoxesImgOrig[2] = pictureBox_vida.Image;
            pictureBoxesImgOrig[3] = pictureBox_cree.Image;
            pictureBoxesImgOrig[4] = pictureBox_divertido.Image;
            pictureBoxesImgOrig[5] = pictureBox_cuerpo.Image;
            pictureBoxesImgOrig[6] = pictureBox_explora.Image;
            pictureBoxesImgOrig[7] = pictureBox_freacaso.Image;
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            aceptacion_Social.Show();
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
