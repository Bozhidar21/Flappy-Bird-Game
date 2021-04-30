using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class GameForm1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 15;
        int score = 0;


        public GameForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Bird_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void score1_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoretext.Text += " Game Over! :(";
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoretext.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }


            if (Bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               Bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -25
               )
            {
                endGame();
            }


            if(score > 10)
            {
                pipeSpeed = 15;
            }

            if(score > 15)
            {
                pipeSpeed = 20;
            }
        }

        
    }
}
