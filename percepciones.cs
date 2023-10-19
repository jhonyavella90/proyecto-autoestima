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

namespace Proyecto_1._1
{
    public partial class percepciones : Form
    {
        private percepciones Percepciones = null;
        private menu menu= null;
        private string autoText = "";



        public percepciones()
        {
            InitializeComponent();
        }

        private void percepciones_Load(object sender, EventArgs e)
        {
            Percepciones = new percepciones();
            menu = new menu();
            autoText = label1.Text;
            label1.Text = "";
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentLength = label1.Text.Length;

            label1.Text += autoText[currentLength];


            if (label1.Text == autoText)
            {
                timer1.Stop();
            }
        }
    }
}
