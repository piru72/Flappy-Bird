using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        GameController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new GameController();
            controller.initializeGame();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
           if (controller.GameIsInIntialMode)
                initialGameSetup();

           if (controller.GameIsStartMode)
                   gameStartSetup();
            



           

        }

        private void initialGameSetup()
        {
            gameTimer.Stop();
            setupVisibility(false);
           
        }

        private void setupVisibility(bool visibility)
        {
            pictureBird.Visible = visibility;
            pictureGroundBottom.Visible = visibility;
            picturePipeTop.Visible = visibility;
            picturePipeBottom.Visible = visibility;
            labelScore.Visible = visibility;
            pictureRetryButon.Visible = visibility;
        }
        private void gameStartSetup () {
            setupVisibility(true);
            pictureRetryButon.Visible = false;
            picturePlayButton.Visible = false;

            manageFrame();

            managePipes();

            manageGameState();
        }

        private void manageFrame()
        {
            pictureBird.Top += controller.Gravity;
            picturePipeBottom.Left -= controller.PipeSpeed;
            picturePipeTop.Left -= controller.PipeSpeed;
            labelScore.Text = "Score :" + controller.Score.ToString();
        }

        private void manageGameState()
        {
            if (pictureBird.Bounds.IntersectsWith(picturePipeBottom.Bounds) ||
              pictureBird.Bounds.IntersectsWith(picturePipeTop.Bounds) ||
              pictureBird.Bounds.IntersectsWith(pictureGroundBottom.Bounds) ||
              pictureBird.Top < -25)

            {
                endGame();
                controller.gameEnd();

            }

            if (controller.isGameEnded())
                pictureRetryButon.Visible = true;
            else

                pictureRetryButon.Visible = false;
        }

        private void managePipes()
        {
            if (picturePipeTop.Left < -150)
            {
                picturePipeTop.Left = 800;
                controller.increaseScore();
            }
            if (picturePipeBottom.Left < -180)
            {
                picturePipeBottom.Left = 950;
                controller.increaseScore();
            }
        }

       

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space)
            {
                controller.Gravity -= 15;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                controller.Gravity += 15;
            
        }

        private void endGame()
        {
            gameTimer.Stop();
            labelScore.Text += " GAME OVER!!";
        }

        

        private void picturePlayButtonOnClick(object sender, EventArgs e)
        {
            gameTimer.Start();
            controller.gameStart();
        }

        private void pictureRetryButon_Click(object sender, EventArgs e)
        {
            pictureBird.Top = 156;
            picturePipeBottom.Left = 500;
            picturePipeTop.Left = 500;

            controller.Score = 0;
            gameTimer.Start();
            controller.gameStart();
        }
    }
}
