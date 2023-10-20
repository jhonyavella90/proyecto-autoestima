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
    public partial class Autoconcepto : Form
    {
        private menu menu = null;   
        private consejos_autoconcepto consejos_Autoconcepto = null;
        //private string autoText = "";
        private Label[] mainLabels;
        private string[] originalTexts;
        private int labelCount = 0;


        public Autoconcepto()
        {
            InitializeComponent();
        }

        private void Autoconcepto_Load(object sender, EventArgs e)
        {
            menu = new menu();
            consejos_Autoconcepto = new consejos_autoconcepto();
            mainLabels = new Label[2];
            originalTexts = new string[2];
            originalTexts[0] = label1.Text;
            originalTexts[1] = label2.Text;
            label1.Text = "";
            label2.Text = "";
            mainLabels[0] = label1;
            mainLabels[1] = label2;
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
            consejos_Autoconcepto.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
