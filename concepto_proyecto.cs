using System;
using System.Windows.Forms;

namespace Proyecto_1._1
{
    public partial class concepto_proyecto : Form
    {
        private menu menu = null;
        private inicio inicio = null;
        private string autoText = "";


        public concepto_proyecto()
        {
            InitializeComponent();
        }

        private void concepto_proyecto_Load(object sender, EventArgs e)
        {
            menu = new menu();
            inicio = new inicio();
            autoText = label1.Text;
            label1.Text = "";
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
            inicio.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
