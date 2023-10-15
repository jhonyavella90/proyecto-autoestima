using System;
using System.Windows.Forms;

namespace Proyecto_1._1
{
    public partial class concepto_proyecto : Form
    {
        private menu menu = null;
        private inicio inicio = null;


        public concepto_proyecto()
        {
            InitializeComponent();
        }

        private void concepto_proyecto_Load(object sender, EventArgs e)
        {
            menu = new menu();
            inicio = new inicio();
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
    }
}
