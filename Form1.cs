using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        GameController controller;
        Random random;
        public Form1()
        {
            InitializeComponent();
            controller = new GameController();
            controller.initializeGame();
            random = new Random();

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
            pictureExitButton.Visible = false;

            manageFrame();

            managePipes();
            manageClouds();

            manageGameState();
        }

        private void manageFrame()
        {
            pictureBird.Top += controller.Gravity;
            picturePipeBottom.Left -= controller.PipeSpeed;
            picturePipeTop.Left -= controller.PipeSpeed;
            pictureCloud1.Left -= 10;
            pictureCloud2.Left -= 20;
            pictureCloud3.Left -= 15;
            pictureCloud4.Left -= 15;
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
            //managePipe(picturePipeTop, -150, 800, 900, 400);
            
            if (picturePipeTop.Left < -150)
            {
                picturePipeTop.Left = random.Next(800, 900); ;
                picturePipeBottom.Top = random.Next(400, 600); ;
                controller.increaseScore();
            }
            if (picturePipeBottom.Left < -180)
            {
                picturePipeBottom.Left = random.Next(900, 1001); ;
                controller.increaseScore();
            }
        }

        

        private void manageClouds()
        {
            if (pictureCloud1.Left < -150)
            
                pictureCloud1.Left = random.Next(700, 1001); ;


            if (pictureCloud2.Left < -250)
                pictureCloud2.Left = random.Next(800, 900); ;


            if (pictureCloud3.Left < -50)
            {
                pictureCloud3.Left = random.Next(500, 700); ;

            }
            if (pictureCloud4.Left < -100)
            {
                pictureCloud4.Left = random.Next(600, 801); ;

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
            
            controller.PipeSpeed = 15;

            controller.Score = 0;
            gameTimer.Start();
            controller.gameStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
