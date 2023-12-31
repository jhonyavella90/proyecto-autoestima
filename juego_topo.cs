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
    public partial class juego_topo : Form
    {
        private juegos _juegos = null;

        Random rnd = new Random();
        int locationNum = 0;
        int score = 0;
        int misses = 0;
        bool isHit = false;
        private void moveMole()
        {
            isHit = false;
            Mole.Enabled = true;
            Mole.Image = Properties.Resources.alive;
            Mole.BackColor = System.Drawing.Color.Transparent;
            switch (locationNum)
            {
                case 1:
                    Mole.Left = 80;
                    Mole.Top = 170;
                    break;
                case 2:
                    Mole.Left = 302;
                    Mole.Top = 151;
                    break;
                case 3:
                    Mole.Left = 566;
                    Mole.Top = 154;
                    break;
                case 4:
                    Mole.Left = 100;
                    Mole.Top = 287;
                    break;
                case 5:
                    Mole.Left = 320;
                    Mole.Top = 250;
                    break;
                case 6:
                    Mole.Left = 530;
                    Mole.Top = 270;
                    break;
                default:
                    break;
            }
        }

       

        public juego_topo()
        {
            InitializeComponent();
        }

        private void gotMole(object sender, EventArgs e)
        {
            score++;
            Mole.Image = Properties.Resources.dead;
            isHit = true;
            Mole.Enabled = false;
        }

        private void movemole(object sender, EventArgs e)
        {
            moveMole();
            lblHit.Text = "Hit: " + score;
            lblMiss.Text = "Miss: " + misses;
            if (isHit == false)
            {
                misses++;
            }
            if (score > 15)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("Felicidades has ganado");
                return;
            }
            else if (misses > 10)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("Lo siento, has perdido");
                return;

            }
        }

        private void juego_topo_Load(object sender, EventArgs e)
        {
            _juegos = new juegos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _juegos.Show();
        }

        private void iniciar_topo_Click(object sender, EventArgs e)
        {
            // Restart the variables for a new game
            locationNum = 0;
            score = 0;
            misses = 0;
            isHit = false;
            timer1.Start();
        }

        private void juego_topo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled) timer1.Stop();
        }
    }
}
