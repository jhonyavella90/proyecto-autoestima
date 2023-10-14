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
    public partial class concejos_acep_social : Form
    {
        private aceptacion_social aceptacion_Social = null;
        private menu menu=null;

        public concejos_acep_social()
        {
            InitializeComponent();
        }

        private void concejos_acep_social_Load(object sender, EventArgs e)
        {
            aceptacion_Social = new aceptacion_social();
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
            aceptacion_Social.Show();
        }
    }
}
