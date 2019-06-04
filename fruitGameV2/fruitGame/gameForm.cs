/*************************************************************************************************

This program simulates a fruit machine with 3 reels of symbols, randomly chosen each time 
the player presses the button "spin".

The image 7 represents "Big Win"
The image 8 represents "Bar"

- Any combination of 2 equal numbers (excluding 7 and 8) will add 5 points to the score
- Any combination of 3 equal numbers (excluding 7 and 8) will add 15 points to the score
- Any combination of 2 equal numbers (7 or 8) will add 200 points to the score
- Any combination of 3 equal numbers (7 or 8) will add 2000 points to the score
- Any combination of 3 different numbers will decrease the score of 50 points

GAME FORM

Michele Chiarello : michele[dot]chiarello[at]gmail[dot]com

**************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruitGame
{
    public partial class frmGame : Form
    {
        //creates some empty audio objects for the animations, to avoid a delay during the game.
        System.Media.SoundPlayer spin_sound = new System.Media.SoundPlayer(Properties.Resources.noSound);
        System.Media.SoundPlayer payout_sound = new System.Media.SoundPlayer(Properties.Resources.noSound);
        System.Media.SoundPlayer gameOver = new System.Media.SoundPlayer(Properties.Resources.noSound);

        int spin = 0; //indicates how many times the images have been spinned
        int preScheduledWin = 0; //check how many times the player has played
        const int playTimes = 100; //maximum number of games before a prescheduled win
        byte[] randIMG = new byte[3]; //array containing the results
        Random r = new Random(); //random r object used to generating the results
        string[] imageName = new string[3]; //array containing the resources names
        int score = startingForm.startingScore; //player credits, initially taken from the startingForm
        bool isClicked = false; //checks if the spin button has already been clicked or not

        public frmGame()
        {
            InitializeComponent();
            getCombination(); //generating the first combination to randomise the picture boxes on the game form, before the game starts
            lblScore.Text = Convert.ToString(score); //updating the score to show the initial credits of the player
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isClicked) //if the spin button is not already clicked, starts to spin
            {
                spin_sound.Play(); //playing the animation
                timer1.Enabled = true;
            }

        }


        private void button1_Click(object sender, EventArgs e) //terminates the application
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e) //timer that handles the spin
        {
            isClicked = true; //deactivating the usage of the spin button
            btnStart.Image = Properties.Resources.Spin_Clicked; //changing the color of the spin button

            if (spin < 30) //spins for 30 times
            {
                getSpinningCombination(); //generates the combination

                spin++; //increases the spin variable

            }
            else
            {

                timer1.Enabled = false; //stopping the timer
                btnStart.Image = Properties.Resources.Spin; //changing again the color of the spin button
                isClicked = false; //activate the usage of the spin button
                spin = 0;
                preScheduledWin++; //increasing the number of times the player has played

                if (preScheduledWin > playTimes) //after "playTimes" times the slot pays with the maximum points.
                {
                    getBigWin();
                    score = score + 2000;
                    lblScore.Text = Convert.ToString(score);
                }
                else
                {
                    getCombination();

                    //score calculation
                    if ((randIMG[0] == randIMG[1] || randIMG[0] == randIMG[2] || randIMG[1] == randIMG[2]) && (randIMG[0] != 7 && randIMG[0] != 8 && randIMG[1] != 7 && randIMG[1] != 8))
                    { //2 equals numbers != 7 and 8 (bigWin and bar)

                        //+5 points
                        score += 5;
                    }
                    else if ((randIMG[0] == randIMG[1] && randIMG[0] == randIMG[2]) && (randIMG[0] != 7 && randIMG[0] != 8))
                    { //3 equals numbers != 7 and 8 (bigWin and bar)

                        //+15 points
                        score += 15;

                    }
                    else if ((randIMG[0] == randIMG[1] || randIMG[0] == randIMG[2] || randIMG[1] == randIMG[2]) && (randIMG[0] == 7 || randIMG[0] == 8 && randIMG[1] == 7 || randIMG[1] == 8))
                    { //2 equals number == to 7 or 8 (bigWin or bar)

                        //+200 points
                        score += 200;

                    }
                    else
                    { //if no-one of the other conditions are satisfied, decreases the points gained of 50 points each time and, if the points are <= 50 show the Game Over message
                        if (score <= 50)
                        {
                            score = 0;
                            lblScore.Text = Convert.ToString(score);
                            gameOver.Play(); //playing the Game Over sound animation
                            MessageBox.Show("GAME OVER!", ":(");
                            preScheduledWin = 0;
                            new startingForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            score -= 50;
                        }
                    }
                    lblScore.Text = Convert.ToString(score);

                }
            }
        }

        private void getCombination() //gets 3 random images from the resources and shows them on the game panel
        {
            for (int i = 0; i < 3; i++)
            {
                randIMG[i] = (byte)r.Next(1, 10); //generating a random number between 1 and 9
                imageName[i] = String.Concat("_" + randIMG[i]); //creating the string to use to get the needed resource
            }

            var drawableID = Properties.Resources.ResourceManager.GetObject(imageName[0]); //getting the image resource
            imgSlot1.Image = (System.Drawing.Image)drawableID; //showing it on the picture box

            drawableID = Properties.Resources.ResourceManager.GetObject(imageName[1]);
            imgSlot2.Image = (System.Drawing.Image)drawableID;

            drawableID = Properties.Resources.ResourceManager.GetObject(imageName[2]);
            imgSlot3.Image = (System.Drawing.Image)drawableID;
        }

        private void getSpinningCombination() //the same job of getCombination() but with blurred images, also present in the resources
        {
            for (int i = 0; i < 3; i++)
            {
                randIMG[i] = (byte)r.Next(1, 10); //generating a random number between 1 and 9
                imageName[i] = String.Concat("_" + randIMG[i] + "b"); //creating the string to use to get the needed resource
            }

            var drawableID = Properties.Resources.ResourceManager.GetObject(imageName[0]); //getting the image resource
            imgSlot1.Image = (System.Drawing.Image)drawableID; //showing it on the picture box

            drawableID = Properties.Resources.ResourceManager.GetObject(imageName[1]);
            imgSlot2.Image = (System.Drawing.Image)drawableID;

            drawableID = Properties.Resources.ResourceManager.GetObject(imageName[2]);
            imgSlot3.Image = (System.Drawing.Image)drawableID;
        }

        private void getBigWin() //generates a big win or bar combination
        {
            randIMG[0] = (byte)r.Next(7, 9); //generating big winning combination (big win or bar)

            imageName[0] = String.Concat("_" + randIMG[0]);
            var drawableID = Properties.Resources.ResourceManager.GetObject(imageName[0]);
            imgSlot1.Image = (System.Drawing.Image)drawableID;
            imgSlot2.Image = (System.Drawing.Image)drawableID;
            imgSlot3.Image = (System.Drawing.Image)drawableID;
            preScheduledWin = 0; //resetting the preScheduledWin variable
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (score > 0 && !isClicked) //if the player has enough credits and is not busy with a game
            {
                payout_sound.Play();
                MessageBox.Show("Congratulation! You won: " + Convert.ToString(score) + "$", "You win!!!");
                score = 0;
                lblScore.Text = Convert.ToString(score);
                btnCash.Enabled = false;
                preScheduledWin = 0;
                new startingForm().Show(); //returning to the main menu
                this.Hide();
            }
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            spin_sound = new System.Media.SoundPlayer(Properties.Resources.spin_sound); //creates a spin_sound object for when the slot is spinning
            payout_sound = new System.Media.SoundPlayer(Properties.Resources.Slot___Payout_Sound_Effect); //creates a payout_sound object for the message box
            gameOver = new System.Media.SoundPlayer(Properties.Resources.Game_Over_sound); //creates a gameOver sound object for when the player lose
        }
    }
}