using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        int userGuess = 0; 


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()
            Form1.storePattern.Clear();
            Refresh(); 
            Thread.Sleep(1500); 
            ComputerTurn(); 
        }

        private void ComputerTurn()
        {
            //Get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            Random randGen = new Random();
            int randValue = 0;
            randValue = randGen.Next(0, 4);

            Form1.storePattern.Add(randValue);

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.storePattern.Count(); i++)
            {
                if (Form1.storePattern.Contains(0) )
                {
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                }

                 else if (Form1.storePattern.Contains(1) )
                {
                    redButton.BackColor = Color.OrangeRed;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                }

                else if (Form1.storePattern.Contains(2) )
                {
                    yellowButton.BackColor = Color.Gold;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                }

                else if (Form1.storePattern.Contains(3) )
                {
                    blueButton.BackColor = Color.LightBlue;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                }
            }

            //TODO: get guess index value back to 0
        }

        public void GameOver()
        {
            //TODO: Play a game over sound
            
            //Close this screen and open the GameOverScreen
            Form1.ChangeScreen(this, new GameOverScreen());
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value at current guess index equal to a green. If so:
                // light up button, play sound, and pause
                // set button colour back to original
                // add one to the guess index
                // check to see if we are at the end of the pattern. If so:
                    // call ComputerTurn() method
                // else call GameOver method
        }
    }
}
