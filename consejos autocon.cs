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
    public partial class consejos_autocon : Form
    {
        private menu menu =null;
        private Autoconfianza autoconfianza=null;
        private consejos_autocon consejos_Autocon=null;



        public consejos_autocon()
        {
            InitializeComponent();
        }

        private void consejos_autocon_Load(object sender, EventArgs e)
        {
            autoconfianza = new Autoconfianza();
            menu = new menu();
            consejos_Autocon = new consejos_autocon();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            autoconfianza.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
