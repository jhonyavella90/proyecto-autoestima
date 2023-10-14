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
    public partial class menu : Form
    {
        private Autoestima autoestima=null;
        private Autoconcepto autoconcepto=null;
        private Autoconfianza autoconfianza=null;   
        private aceptacion_social aceptacion_Social=null;
        private percepciones percepciones=null;
        private inicio inicio=null;
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
          autoestima = new Autoestima();
            autoconcepto = new Autoconcepto();
            autoconfianza = new Autoconfianza();
            aceptacion_Social = new aceptacion_social();
            percepciones = new percepciones();
            inicio = new inicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            autoestima.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            autoconfianza.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            aceptacion_Social.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            autoconcepto.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            percepciones.Show();    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio.Show();  
        }
    }
}
