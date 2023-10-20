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
    public partial class creditos : Form
    {
        inicio inicio = null;
        creditos Creditos = null;
        private Label[] mainLabels;
        private string[] originalTexts;
        private int labelCount = 0;
        private string autoText = "";
        public creditos()
        {
            InitializeComponent();
        }

        private void creditos_Load(object sender, EventArgs e)
        {
           inicio = new inicio();   
            Creditos = new creditos();
            autoText = label1.Text;
            label1.Text = "";
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio.Show(); 
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
