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
    public partial class creditos : Form
    {
        inicio inicio = null;
        creditos Creditos = null;
        public creditos()
        {
            InitializeComponent();
        }

        private void creditos_Load(object sender, EventArgs e)
        {
           inicio = new inicio();   
            Creditos = new creditos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio.Show(); 
        }
    }
}
