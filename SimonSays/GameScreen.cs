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
        //Create guess variable to track what part of the pattern the user is at
        int guessCounter = 0;

        //Delays for lighting up buttons
        int time = 700;
        int time2 = 200;


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
                if (Form1.storePattern[i] == 0)
                {
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(time);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                    Thread.Sleep(time2);
                }

                else if (Form1.storePattern[i] == 1)
                {
                    redButton.BackColor = Color.OrangeRed;
                    Refresh();
                    Thread.Sleep(time);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    Thread.Sleep(time2);
                }

                else if (Form1.storePattern[i] == 2)
                {
                    yellowButton.BackColor = Color.Gold;
                    Refresh();
                    Thread.Sleep(time);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                    Thread.Sleep(time2);
                }

                else if (Form1.storePattern[i] == 3)
                {
                    blueButton.BackColor = Color.LightBlue;
                    Refresh();
                    Thread.Sleep(time);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                    Thread.Sleep(time2);
                }
            }

            //Get guess index value back to 0
            guessCounter = 0;
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
            //Is the value in the pattern list at index [guess] equal to a green?
            // change button color
            // play sound
            // refresh
            // pause
            // set button colour back to original
            // add one to the guess variable

            //Check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method

            if (Form1.storePattern[guessCounter] == 0)
            {
                greenButton.BackColor = Color.LightGreen;
                Refresh();
                Thread.Sleep(time);
                greenButton.BackColor = Color.ForestGreen;
                Refresh();
                Thread.Sleep(time2);
                guessCounter++;

            }

            else
            {
                GameOver();
            }

            if (Form1.storePattern.Count == guessCounter)
            {
                Thread.Sleep(time);
                ComputerTurn();
            }



        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.storePattern[guessCounter] == 1)
            {
                redButton.BackColor = Color.OrangeRed;
                Refresh();
                Thread.Sleep(time);
                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(time2);
                guessCounter++;
            }

            else
            {
                GameOver();
            }

            if (Form1.storePattern.Count == guessCounter)
            {
                Thread.Sleep(time);
                ComputerTurn();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.storePattern[guessCounter] == 2)
            {
                yellowButton.BackColor = Color.Gold;
                Refresh();
                Thread.Sleep(time);
                yellowButton.BackColor = Color.Goldenrod;
                Refresh();
                Thread.Sleep(time2);
                guessCounter++;
            }

            else
            {
                GameOver();
            }

            if (Form1.storePattern.Count == guessCounter)
            {
                Thread.Sleep(time);
                ComputerTurn();
            }          
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.storePattern[guessCounter] == 3)
            {
                blueButton.BackColor = Color.LightBlue;
                Refresh();
                Thread.Sleep(time);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                Thread.Sleep(time2);
                guessCounter++;
            }

            else
            {
                GameOver();
            }

            if (Form1.storePattern.Count == guessCounter)
            {
                Thread.Sleep(time);
                ComputerTurn();
            }         
        }
    }
}
