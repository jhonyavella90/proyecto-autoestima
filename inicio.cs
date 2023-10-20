using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Proyecto_1._1
{
    public partial class inicio : Form
    {
        private concepto_proyecto form2 = null;
        private creditos form3 = null;
        private juegos form_juegos = null;
        
        public inicio()
        {
            InitializeComponent();
        }
        private void inicio_Load(object sender, EventArgs e)
        {
            form2 = new concepto_proyecto();
            form3 = new creditos();
            form_juegos = new juegos();
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

        private void boton_de_juegos_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_juegos.Show();
        }

        private void inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the application.
            Application.Exit();
        }
    }
}
