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
        private menu menu = null;
        private consejos_autocon consejos_Autocon = null;
        private Autoconfianza autoconfianza = null;
        //private string autoText1 = "";
        //private string autoText2 = "";
        private Label[] mainLabels;
        private string[] originalTexts;
        private int labelCount = 0;

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
            mainLabels = new Label[2];
            originalTexts = new string[2];
            originalTexts[0] = label1.Text;
            originalTexts[1] = label2.Text;
            label1.Text = "";
            label2.Text = "";
            mainLabels[0] = label1;
            mainLabels[1] = label2;
            //autoText1 = label1.Text;
            //autoText2 = label2.Text;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consejos_Autocon.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int currentLength1 = label1.Text.Length;
            //int currentLength2 = label2.Text.Length;

            //if (currentLength1 < autoText1.Length)
            //{
            //    label1.Text += autoText1[currentLength1];
            //}

            //if (currentLength2 < autoText2.Length)
            //{
            //    label2.Text += autoText2[currentLength2];
            //}

            //if (label1.Text == autoText1 && label2.Text == autoText2)
            //{
            //    timer1.Stop();
            //}

            int currentLength1 = mainLabels[labelCount].Text.Length;
            mainLabels[labelCount].Text += originalTexts[labelCount][currentLength1];
            if (mainLabels[labelCount].Text == originalTexts[labelCount])
            {
                timer1.Stop();
                labelCount += 1;
                if (labelCount == mainLabels.Length) return;
                timer1.Start();
            }
        }
    }
}
