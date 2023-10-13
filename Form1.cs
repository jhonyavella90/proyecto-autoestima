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
    public partial class Form1 : Form
    {
        private concepto_proyecto form2 = null;
        private creditos form3 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new concepto_proyecto();
            form3 = new creditos();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void boton_creditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }
    }
}
