using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public class GameController 
    {
        private int score ;
        private int pipeSpeed ;
        private int gravity ;
        private int gameState;

        public GameController() {

            score = 0;
            pipeSpeed = 8;
            gravity = 8;
            gameState = 1;
        }
        public int Score { get { return score; }  set { score = value; } }
        public int GameState { get { return gameState; } }

        public bool GameIsInIntialMode { get { return gameState == 0 ; } }
        public bool GameIsStartMode { get { return gameState == 1; } }
        public int PipeSpeed { get
            {
                
                if (score > 5) pipeSpeed = 15;
                if (score > 15) pipeSpeed = 25;
                if (score > 25) pipeSpeed = 35;
                if (score > 35) pipeSpeed = 45;
                if (score > 45) pipeSpeed = 55;
                if (score > 55) pipeSpeed = 65;
                if (score > 65) pipeSpeed = 75;
                if (score > 75) pipeSpeed = 85;
                if (score > 85) pipeSpeed = 95;
                return pipeSpeed; 
            }
            set { pipeSpeed= value; }
        }
        public int Gravity { get { return gravity; } set { gravity = value; } }
        

        public void pipeControllerBottom(PictureBox picturePipeBottom)
        {
            if (picturePipeBottom.Left < -180)
            {
                picturePipeBottom.Left = 950;
                score++;
            }
        }

        public void pipeControllerTop(PictureBox picturePipeTop)
        {
            if (picturePipeTop.Left < -150)
            {
                picturePipeTop.Left = 800;
                score++;
            }
        }

        public void increaseScore()
        {
            score++;
        }

        public void gameEnd()
        {
            gameState = 0;
        }

        public bool isGameEnded()
        {
            return gameState == 0;
        }

        public void gameStart()
        {
            gameState = 1;
        }

        internal void initializeGame()
        {
            gameState = 0;
        }
    }
}
