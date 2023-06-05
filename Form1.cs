using System;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pictureBird.Top += gravity;
            picturePipeBottom.Left -= pipeSpeed;
            picturePipeTop.Left -= pipeSpeed;
            labelScore.Text ="Score :" + score.ToString();

            if (picturePipeTop.Left < -150)
            {
                picturePipeTop.Left = 800;
                score++;
            }
            if (picturePipeBottom.Left < -180)
            {
                picturePipeBottom.Left = 950;
                score++;
            }

            if (pictureBird.Bounds.IntersectsWith(picturePipeBottom.Bounds) ||
               pictureBird.Bounds.IntersectsWith(picturePipeTop.Bounds) || 
               pictureBird.Bounds.IntersectsWith(pictureGroundBottom.Bounds) ||
               pictureBird.Top < -25)

            {
                endGame();

            }

            if (score>5) pipeSpeed = 15;
            if (score > 15) pipeSpeed = 15;
            if (score > 25) pipeSpeed = 15;
            if (score > 35) pipeSpeed = 15;
            if (score > 45) pipeSpeed = 15;
            if (score > 55) pipeSpeed = 15;
            if (score > 65) pipeSpeed = 15;
            if (score > 75) pipeSpeed = 15;
            if (score > 85) pipeSpeed = 15;


        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space)
            {
                gravity -= 15;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity += 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            labelScore.Text += " GAME OVER!!";
        }
    }
}
