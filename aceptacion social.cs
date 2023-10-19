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
    public partial class aceptacion_social : Form
    {
        private menu menu = null;
        private concejos_acep_social concejos_Acep_Social = null;
        private string autoText = "";

        public aceptacion_social()
        {
            InitializeComponent();
        }

        private void aceptacion_social_Load(object sender, EventArgs e)
        {
            concejos_Acep_Social = new concejos_acep_social();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            concejos_Acep_Social.Show();
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
