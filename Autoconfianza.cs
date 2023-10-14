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
        private menu menu=null;
        private consejos_autocon consejos_Autocon = null;
        private Autoconfianza autoconfianza = null;


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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consejos_Autocon.Show();
        }
    }
}
