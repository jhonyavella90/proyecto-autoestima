using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_1._1
{
    public partial class Autoestima : Form
    {
        private menu menu = null;
        private consejos_autoestima consejos_Autoestima = null;
        private string autoText = "";

        public Autoestima()
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void Autoestima_Load(object sender, EventArgs e)
        {
            consejos_Autoestima = new consejos_autoestima();
            menu = new menu();
            autoText = label1.Text;
            label1.Text = "";
            //textBox1.BackColor = Color.Transparent;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consejos_Autoestima.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the current length of the text in the textbox.
            int currentLength = label1.Text.Length;
            // Add the next character to the text in the textbox.
            label1.Text += autoText[currentLength];

            // If the textbox contains all of the text, stop the timer.
            if (label1.Text == autoText)
            {
                timer1.Stop();
            }
        }
    }
}
