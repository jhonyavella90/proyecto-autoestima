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
    public partial class juego_preguntas : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        private juegos _juegos = null;

        public juego_preguntas()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz terminado!" + Environment.NewLine +
                    "Tu has respondido " + score + " preguntas correctas." + Environment.NewLine +
                    "Tu porcentaje total es " + percentage + "%" + Environment.NewLine +
                    "Click en Aceptar Para jugar nuevamente"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.quiz_question;
                    lblQuestion.Text = "Una de las principales cualidad del autoconcepto es...";
                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Red";
                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.quiz_question;
                    lblQuestion.Text = "What is the name of the main character from Iron Man?";
                    button1.Text = "Tony Stank";
                    button2.Text = "Tony Stark";
                    button3.Text = "Rody";
                    button4.Text = "Peter Quill";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.quiz_aceptacion_social;
                    lblQuestion.Text = "Que representa la siguente imagen?";
                    button1.Text = "Autoestima";
                    button2.Text = "Percepciones";
                    button3.Text = "Autocencepto";
                    button4.Text = "Aceptacion Social";
                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.quiz_autoconcepto;
                    lblQuestion.Text = "Que representa la siguente imagen??";
                    button1.Text = "Discriminacion";
                    button2.Text = "Confianza";
                    button3.Text = "Autoconcepto";
                    button4.Text = "Percepciones";
                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.quiz_autoconfianza;
                    lblQuestion.Text = "Que representa la siguente imagen?";
                    button1.Text = "Autoconfianza";
                    button2.Text = "Sentimientos";
                    button3.Text = "Libertad";
                    button4.Text = "Autoestima";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.quiz_autoestima;
                    lblQuestion.Text = "Que representa la siguente imagen?";
                    button1.Text = "Amor";
                    button2.Text = "Conceptos";
                    button3.Text = "Autoestima";
                    button4.Text = "Percepciones";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.quiz_percepciones;
                    lblQuestion.Text = "Que representa la siguente imagen?";
                    button1.Text = "Observaciones";
                    button2.Text = "Criticas";
                    button3.Text = "Percepciones";
                    button4.Text = "Emociones";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.quiz_question;
                    lblQuestion.Text = "Que caracteriza a la autoestima?";
                    button1.Text = "Aceptación";
                    button2.Text = "Confianza";
                    button3.Text = "Respeto";
                    button4.Text = "Risa";
                    correctAnswer = 4;
                    break;
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            _juegos.Show();
        }

        private void juego_preguntas_Load(object sender, EventArgs e)
        {
            _juegos = new juegos();
        }
    }
}
