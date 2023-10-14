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
    public partial class consejos_autoconcepto : Form
    {
        Autoconcepto autoconcepto = null;   
        consejos_autocon consejos_Autoconcepto = null;
        menu menu = null;

        public consejos_autoconcepto()
        {
            InitializeComponent();
        }

        private void consejos_autoconcepto_Load(object sender, EventArgs e)
        {
            autoconcepto = new Autoconcepto();
            consejos_Autoconcepto = new consejos_autocon();
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
            autoconcepto.Show();
        }
    }
}
