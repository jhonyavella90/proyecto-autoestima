using System;
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
    public partial class Autoconfianza : Form
    {
        private menu menu=null;
        private consejos_autocon consejos_Autocon = null;
        private Autoconfianza autoconfianza = null;
        private string autoText = "";



        public Autoconfianza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void Autoconfianza_Load(object sender, EventArgs e)
        {
            autoconfianza = new Autoconfianza();
            menu = new menu();
            consejos_Autocon = new consejos_autocon();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Usuario\source\repos\proyecto-autoestima\autoconfi.gif");
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            autoText = label1.Text;
            label1.Text = "";
            timer1.Enabled = true;
            autoText = label2.Text;
            label2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consejos_Autocon.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentLength = label2.Text.Length;
            label1.Text += autoText[currentLength];

            label2.Text += autoText[currentLength];
            if (label1.Text == autoText)
            {
                timer1.Stop();

            }
        }
    }
}
