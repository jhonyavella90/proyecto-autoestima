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
    public partial class juego_memoria : Form
    {
        private juegos _juegos = null;
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();  
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };


        private PictureBox [] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }

        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.memoria_img1,
                    Properties.Resources.memoria_img2,
                    Properties.Resources.memoria_img3,
                    Properties.Resources.memoria_img4,
                    Properties.Resources.memoria_img5,
                    Properties.Resources.memoria_img6,
                    Properties.Resources.memoria_img7,
                    Properties.Resources.memoria_img8,
                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Se acabo el Tiempo");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text= "00: " + time.ToString();
            };
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }

        private void HideImages()
        {
            foreach ( var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.memoria_girada;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach( var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages ();  

            allowClick= true;
            clickTimer.Stop();
        }

        public juego_memoria()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages ();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox) sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible= firstGuess.Visible= false;
                {
                    firstGuess=pic;
                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("Has Ganado");
            ResetImages();
        }

        private void juego_memoria_Load(object sender, EventArgs e)
        {
            _juegos = new juegos();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            _juegos.Show();
        }
    }
}
