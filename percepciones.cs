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
    public partial class percepciones : Form
    {
        private percepciones Percepciones = null;
        private menu menu= null;


        public percepciones()
        {
            InitializeComponent();
        }

        private void percepciones_Load(object sender, EventArgs e)
        {
            Percepciones = new percepciones();
            menu = new menu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
