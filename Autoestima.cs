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
    public partial class Autoestima : Form
    {
        private menu menu=null;
        private consejos_autoestima consejos_Autoestima=null;

        public Autoestima()
        {
            InitializeComponent();
        }

        private void Autoestima_Load(object sender, EventArgs e)
        {
            consejos_Autoestima = new consejos_autoestima();
            menu = new menu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consejos_Autoestima.Show();
        }
    }
}
