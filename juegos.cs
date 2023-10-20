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
    public partial class juegos : Form
    {
        private juego_topo form_topo = null;
        private inicio Inicio = null;
        public juegos()
        {
            InitializeComponent();
        }

        private void juegos_Load(object sender, EventArgs e)
        {
            form_topo = new juego_topo();
            Inicio = new inicio();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Show();
        }

        private void boton_topo_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_topo.Show();
        }
    }
}
