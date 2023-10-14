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
    public partial class consejos_autoestima : Form
    {
        private inicio inicio = null;
        private consejos_autoestima consejos_Autoestima = null;
        private menu menu = null;
        private Autoestima Autoestima=null;


        public consejos_autoestima()
        {
            InitializeComponent();
        }

        private void consejos_autoestima_Load(object sender, EventArgs e)
        {
            consejos_Autoestima = new consejos_autoestima();
            inicio = new inicio();
            menu = new menu();
            Autoestima = new Autoestima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           Autoestima.Show();
        }
    }
}
