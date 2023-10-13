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
        private Form1 form_topo = null;
        public juegos()
        {
            InitializeComponent();
        }

        private void juegos_Load(object sender, EventArgs e)
        {
            form_topo = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_topo.Show();
        }
    }
}
